﻿using JNCC.PublicWebsite.Core.Utilities;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace JNCC.PublicWebsite.Core.Providers
{
    internal sealed class UmbracoArticleYearsProvider : UmbracoArticlePagesProvider, IArticleYearsProvider<IPublishedContent>
    {
        private IEnumerable<int> GetArticleYears(IPublishedContent root)
        {
            var articlePages = GetArticlePages(root);
            if (ExistenceUtility.IsNullOrEmpty(articlePages))
            {
                return Enumerable.Empty<int>();
            }

            return articlePages.Select(x => x.PublishDate.Year).Distinct();
        }

        public IEnumerable<int> GetAllByRoot(IPublishedContent root)
        {
            return GetArticleYears(root).OrderBy(x => x);
        }

        public IEnumerable<int> GetAllByRootDescending(IPublishedContent root)
        {
            return GetArticleYears(root).OrderByDescending(x => x);
        }
    }
}
