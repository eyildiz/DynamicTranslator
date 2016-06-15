﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Abp.Dependency;

using DynamicTranslator.Orchestrators.Model;

namespace DynamicTranslator.Orchestrators.Organizer
{
    public interface IResultOrganizer : ITransientDependency
    {
        Task<Maybe<string>> OrganizeResult(ICollection<TranslateResult> findedMeans, string currentString);
    }
}