﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;

using Abp.Dependency;

using DynamicTranslator.Configuration.Startup;
using DynamicTranslator.Extensions;

using RestSharp;

namespace DynamicTranslator.Wpf.Orchestrators.Detector
{
    public class GoogleLanguageDetector : ILanguageDetector, ISingletonDependency
    {
        private readonly IApplicationConfiguration applicationConfiguration;
        private readonly IGoogleDetectorConfiguration configuration;

        public GoogleLanguageDetector(IGoogleDetectorConfiguration configuration, IApplicationConfiguration applicationConfiguration)
        {
            this.configuration = configuration;
            this.applicationConfiguration = applicationConfiguration;
        }

        public async Task<string> DetectLanguage(string text)
        {
            var uri = string.Format(
                configuration.Url,
                applicationConfiguration.ToLanguage.Extension,
                applicationConfiguration.ToLanguage.Extension,
                HttpUtility.UrlEncode(text));

            var response = await new RestClient(uri)
                .ExecuteGetTaskAsync(new RestRequest(Method.GET)
                    .AddHeader("Accept-Language", "en-US,en;q=0.8,tr;q=0.6")
                    .AddHeader("Accept-Encoding", "gzip, deflate, sdch")
                    .AddHeader("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/46.0.2490.80 Safari/537.36")
                    .AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8"));

            var result = await Task.Run(() => response.Content.DeserializeAs<Dictionary<string, object>>());
            return result?["src"]?.ToString() ?? applicationConfiguration.FromLanguage.Extension;
        }
    }
}