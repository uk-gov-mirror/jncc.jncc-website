//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace JNCC.PublicWebsite.Core.Models
{
	/// <summary>iFrame Page</summary>
	[PublishedContentModel("iFramePage")]
	public partial class IFramePage : PublishedContentModel, INavigationSettingsComposition, IPageSpecificIncludesComposition, ISeoComposition
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "iFramePage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public IFramePage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<IFramePage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Cookie Disabled Error: This is the message displayed if the user has not accepted the cookies on the website
		///</summary>
		[ImplementPropertyType("cookieDisabledError")]
		public IHtmlString CookieDisabledError
		{
			get { return this.GetPropertyValue<IHtmlString>("cookieDisabledError"); }
		}

		///<summary>
		/// Display on Medium Devices ?: Set to true, to display above fallback content on medium devices (Tablet)
		///</summary>
		[ImplementPropertyType("displayOnMediumDevices")]
		public bool DisplayOnMediumDevices
		{
			get { return this.GetPropertyValue<bool>("displayOnMediumDevices"); }
		}

		///<summary>
		/// Display on Small Devices ?: Set to true, to display above fallback content on small devices (Mobile)
		///</summary>
		[ImplementPropertyType("displayOnSmallDevices")]
		public bool DisplayOnSmallDevices
		{
			get { return this.GetPropertyValue<bool>("displayOnSmallDevices"); }
		}

		///<summary>
		/// Navigation: An optional collection of navigation links which is independent of the main navigation and will only appear on this iFrame page.
		///</summary>
		[ImplementPropertyType("navigation")]
		public IEnumerable<RJP.MultiUrlPicker.Models.Link> Navigation
		{
			get { return this.GetPropertyValue<IEnumerable<RJP.MultiUrlPicker.Models.Link>>("navigation"); }
		}

		///<summary>
		/// Passthrough Querystring Parameters: Allows any querystrings being passed in via the URL to be appended to the source URL of the the iframe.
		///</summary>
		[ImplementPropertyType("passthroughQuerystringParameters")]
		public bool PassthroughQuerystringParameters
		{
			get { return this.GetPropertyValue<bool>("passthroughQuerystringParameters"); }
		}

		///<summary>
		/// Source URL: The URL that displays within the iFrame.
		///</summary>
		[ImplementPropertyType("sourceURL")]
		public string SourceUrl
		{
			get { return this.GetPropertyValue<string>("sourceURL"); }
		}

		///<summary>
		/// Hide from Navigation: Hides the page from the main navigation.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return JNCC.PublicWebsite.Core.Models.NavigationSettingsComposition.GetUmbracoNaviHide(this); }
		}

		///<summary>
		/// Hide Children from Navigation: Hides any child pages from the main navigation.
		///</summary>
		[ImplementPropertyType("umbracoNaviHideChildren")]
		public bool UmbracoNaviHideChildren
		{
			get { return JNCC.PublicWebsite.Core.Models.NavigationSettingsComposition.GetUmbracoNaviHideChildren(this); }
		}

		///<summary>
		/// HTML Lang Ref: This field should be used when the page is of another language.  When a value is not present in this field, the default value will be "en-GB".
		///</summary>
		[ImplementPropertyType("hTMLLangRef")]
		public string HTmllangRef
		{
			get { return JNCC.PublicWebsite.Core.Models.PageSpecificIncludesComposition.GetHTmllangRef(this); }
		}

		///<summary>
		/// Page-specific BODY Includes: Authored code includes which will only appear on this page and will be rendered at the end of the BODY tag in the HTML.  This is useful for adding tracking code. Styling should not be authored here and should instead be authored in the head.  This should be edited by administrators only.
		///</summary>
		[ImplementPropertyType("pageSpecificBodyIncludes")]
		public string PageSpecificBodyIncludes
		{
			get { return JNCC.PublicWebsite.Core.Models.PageSpecificIncludesComposition.GetPageSpecificBodyIncludes(this); }
		}

		///<summary>
		/// Page-specific HEAD Includes: Authored code includes which will only appear on this page and will be rendered at the end of the HEAD tag in the HTML.  This is useful for adding tracking code and style elements.  This should be edited by administrators only.
		///</summary>
		[ImplementPropertyType("pageSpecificHeadIncludes")]
		public string PageSpecificHeadIncludes
		{
			get { return JNCC.PublicWebsite.Core.Models.PageSpecificIncludesComposition.GetPageSpecificHeadIncludes(this); }
		}

		///<summary>
		/// NoIndex: The default value for this is False, if the checkbox is set to true the NoIndex property will be added to this page
		///</summary>
		[ImplementPropertyType("noIndex")]
		public bool NoIndex
		{
			get { return JNCC.PublicWebsite.Core.Models.SeoComposition.GetNoIndex(this); }
		}

		///<summary>
		/// SEO Settings
		///</summary>
		[ImplementPropertyType("seoSettings")]
		public SEOChecker.MVC.MetaData SeoSettings
		{
			get { return JNCC.PublicWebsite.Core.Models.SeoComposition.GetSeoSettings(this); }
		}
	}
}
