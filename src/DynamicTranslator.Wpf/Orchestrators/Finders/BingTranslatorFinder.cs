﻿using System;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

using DynamicTranslator.Application.Model;
using DynamicTranslator.Configuration.Startup;
using DynamicTranslator.Constants;
using DynamicTranslator.Domain.Model;
using DynamicTranslator.Wpf.Orchestrators.Organizers;

using Newtonsoft.Json;

using RestSharp;

namespace DynamicTranslator.Wpf.Orchestrators.Finders
{
    public class BingTranslatorFinder : IMeanFinder
    {
        private const string ContentType = "application/json;Charset=UTF-8";

        private readonly IApplicationConfiguration applicationConfiguration;
        private readonly IBingTranslatorConfiguration bingConfiguration;
        private readonly IMeanOrganizerFactory meanOrganizerFactory;

        public BingTranslatorFinder(IBingTranslatorConfiguration bingConfiguration, IMeanOrganizerFactory meanOrganizerFactory,
            IApplicationConfiguration applicationConfiguration)
        {
            this.bingConfiguration = bingConfiguration;
            this.meanOrganizerFactory = meanOrganizerFactory;
            this.applicationConfiguration = applicationConfiguration;
        }

        public async Task<TranslateResult> Find(TranslateRequest translateRequest)
        {
            if (!bingConfiguration.IsAppropriateForTranslation(translateRequest.FromLanguageExtension))
                return new TranslateResult(false, new Maybe<string>());

            var requestObject = new
            {
                from = applicationConfiguration.FromLanguage.Extension.ToLower(),
                to = applicationConfiguration.ToLanguage.Extension.ToLower(),
                text = translateRequest.CurrentText
            };

            var response = await new RestClient(bingConfiguration.Url)
            {
                Encoding = Encoding.UTF8,
                CachePolicy = new HttpRequestCachePolicy(HttpCacheAgeControl.MaxAge, TimeSpan.FromHours(1))
            }.ExecutePostTaskAsync(new RestRequest(Method.POST)
                .AddParameter(ContentType,
                    JsonConvert.SerializeObject(requestObject),
                    ParameterType.RequestBody));

            var meanOrganizer = meanOrganizerFactory.GetMeanOrganizers().First(x => x.TranslatorType == TranslatorType);
            var mean = await meanOrganizer.OrganizeMean(response.Content);

            return new TranslateResult(true, mean);
        }

        public TranslatorType TranslatorType => TranslatorType.Bing;
    }
}