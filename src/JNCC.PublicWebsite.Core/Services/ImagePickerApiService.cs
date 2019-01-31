﻿using JNCC.PublicWebsite.Core.Models;
using JNCC.PublicWebsite.Core.ViewModels;
using System.Collections.Generic;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Models;
using static Umbraco.Core.Constants;

namespace JNCC.PublicWebsite.Core.Services
{
    internal sealed class ImagePickerApiService
    {
        private readonly UmbracoHelper _umbracoHelper;
        private readonly MediaUrlResolverService _mediaUrlResolverService;

        public ImagePickerApiService(UmbracoHelper umbracoHelper, MediaUrlResolverService mediaUrlResolverService)
        {
            _umbracoHelper = umbracoHelper;
            _mediaUrlResolverService = mediaUrlResolverService;
        }

        public bool TryFindRoot(int id, out IPublishedContent root)
        {
            root = _umbracoHelper.TypedMedia(id);

            if (root == null)
            {
                return false;
            }

            return root is Folder;
        }

        public IEnumerable<ImagePickerApiViewModel> GetImages(IPublishedContent root)
        {
            foreach (var image in root.Descendants<Image>())
            {
                yield return GetImage(image);
            }
        }

        private ImagePickerApiViewModel GetImage(Image image)
        {
            return new ImagePickerApiViewModel()
            {
                EditorName = image.WriterName,
                FileType = image.UmbracoExtension,
                LastEdited = image.UpdateDate,
                Url = _mediaUrlResolverService.ResolveUrl(image.Url),
                Crops = GetImageCrops(image)
            };
        }

        private IDictionary<string, string> GetImageCrops(Image image)
        {
            var cropsData = image.GetPropertyValue<ImageCropDataSet>(Conventions.Media.File);
            var dictionary = new Dictionary<string, string>();

            if (cropsData == null)
            {
                return dictionary;
            }

            foreach (var crop in cropsData.Crops)
            {
                var url = image.GetCropUrl(crop.Alias);
                var resolvedUrl = _mediaUrlResolverService.ResolveUrl(url);

                dictionary.Add(crop.Alias, resolvedUrl);
            }

            return dictionary;
        }
    }
}
