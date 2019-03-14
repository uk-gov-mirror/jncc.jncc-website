﻿using JNCC.PublicWebsite.Core.Models;
using JNCC.PublicWebsite.Core.Utilities;
using JNCC.PublicWebsite.Core.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace JNCC.PublicWebsite.Core.Extensions
{
    internal static class SciencePagesExtensions
    {
        public static char GetCategorisationCharacter<T>(this T model) where T : ISciencePageCategorisationComposition, IPageHeroComposition
        {
            var names = new string[]
            {
                model.CategoryOrderingName,
                model.Headline,
                model.Name
            };

            var firstAvailableName = names.FirstOrDefault(x => string.IsNullOrWhiteSpace(x) == false);

            return firstAvailableName.ToUpper().First();
        }

        public static IReadOnlyDictionary<char, IEnumerable<NavigationItemViewModel>> CategorisePages<T>(this IEnumerable<T> pages) where T : ISciencePageCategorisationComposition, IPageHeroComposition
        {
            return pages.GroupBy(x => x.GetCategorisationCharacter())
                        .OrderBy(x => x.Key)
                        .ToDictionary(x => x.Key, x => x.Select(y => new NavigationItemViewModel()
                        {
                            Text = y.GetHeadline(),
                            Url = y.Url
                        }));
        }
    }
}
