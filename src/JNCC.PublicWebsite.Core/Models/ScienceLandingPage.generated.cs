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
	/// <summary>Science Landing Page</summary>
	[PublishedContentModel("scienceLandingPage")]
	public partial class ScienceLandingPage : PublishedContentModel, INavigationSettingsComposition, IPageHeroComposition, IPageSpecificIncludesComposition, ISeoComposition
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "scienceLandingPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ScienceLandingPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ScienceLandingPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// A to Z Page Link: The link to the A to Z directory of all science pages.  This link appears below the latest update items. If no link is authored then the link will not be displayed.
		///</summary>
		[ImplementPropertyType("aToZPageLink")]
		public RJP.MultiUrlPicker.Models.Link AToZpageLink
		{
			get { return this.GetPropertyValue<RJP.MultiUrlPicker.Models.Link>("aToZPageLink"); }
		}

		///<summary>
		/// Featured Quote: A featured quote which highlights the scientific research work done by JNCC.  This is optional and if no quote is provided it will not be displayed on the page.
		///</summary>
		[ImplementPropertyType("featuredQuote")]
		public string FeaturedQuote
		{
			get { return this.GetPropertyValue<string>("featuredQuote"); }
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
		/// Headline: A headline that appears above the main content of the page.  If no value is provided the page name will be used instead.  If a hero image is also provided then this headline appears over the hero image. Otherwise it appears just above the main content.
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return JNCC.PublicWebsite.Core.Models.PageHeroComposition.GetHeadline(this); }
		}

		///<summary>
		/// Hero Image: The hero image which is displayed above the main content of the page.
		///</summary>
		[ImplementPropertyType("heroImage")]
		public IPublishedContent HeroImage
		{
			get { return JNCC.PublicWebsite.Core.Models.PageHeroComposition.GetHeroImage(this); }
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
