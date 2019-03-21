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
	/// <summary>Science Details Page</summary>
	[PublishedContentModel("scienceDetailsPage")]
	public partial class ScienceDetailsPage : PublishedContentModel, IGetInTouchComposition, INavigationSettingsComposition, IPageHeroComposition, IPageMetaInformationComposition, IPageSpecificIncludesComposition, IRelatedItemsComposition, ISciencePageCategorisationComposition, ISeoComposition, ISidebarComposition
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "scienceDetailsPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ScienceDetailsPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ScienceDetailsPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Preamble: Introductory content explaining the purpose of the page.
		///</summary>
		[ImplementPropertyType("preamble")]
		public IHtmlString Preamble
		{
			get { return this.GetPropertyValue<IHtmlString>("preamble"); }
		}

		///<summary>
		/// Reviewed Date: The date the page last had a meaningful editorial review.
		///</summary>
		[ImplementPropertyType("reviewedDate")]
		public DateTime ReviewedDate
		{
			get { return this.GetPropertyValue<DateTime>("reviewedDate"); }
		}

		///<summary>
		/// Get in Touch Button: The link & text for the Get in Touch button which accompanies the Get in Touch content below the main content of the page.
		///</summary>
		[ImplementPropertyType("getInTouchButton")]
		public RJP.MultiUrlPicker.Models.Link GetInTouchButton
		{
			get { return JNCC.PublicWebsite.Core.Models.GetInTouchComposition.GetGetInTouchButton(this); }
		}

		///<summary>
		/// Get In Touch Content: Optional content which appears below the main content of the page. This content is specifically for encouraging website users to navigate to the contact form.
		///</summary>
		[ImplementPropertyType("getInTouchContent")]
		public IHtmlString GetInTouchContent
		{
			get { return JNCC.PublicWebsite.Core.Models.GetInTouchComposition.GetGetInTouchContent(this); }
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
		/// Published Date: The date is when the page was first published.   This is a required property as a page with a Meta Information must have a published date.
		///</summary>
		[ImplementPropertyType("publishedDate")]
		public DateTime PublishedDate
		{
			get { return JNCC.PublicWebsite.Core.Models.PageMetaInformationComposition.GetPublishedDate(this); }
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
		/// Items: Provides related items for the current page. These items are manually authored. A maximum of 3 items can be authored.  If no items are provided then the related items section will not be rendered.
		///</summary>
		[ImplementPropertyType("relatedItems")]
		public IEnumerable<IPublishedContent> RelatedItems
		{
			get { return JNCC.PublicWebsite.Core.Models.RelatedItemsComposition.GetRelatedItems(this); }
		}

		///<summary>
		/// Category Ordering Name: [Optional] Determines how the page is categorised on a Science Category Page.   If no value is authored then the headline is used followed by the page name.
		///</summary>
		[ImplementPropertyType("categoryOrderingName")]
		public string CategoryOrderingName
		{
			get { return JNCC.PublicWebsite.Core.Models.SciencePageCategorisationComposition.GetCategoryOrderingName(this); }
		}

		///<summary>
		/// SEO Settings
		///</summary>
		[ImplementPropertyType("seoSettings")]
		public SEOChecker.MVC.MetaData SeoSettings
		{
			get { return JNCC.PublicWebsite.Core.Models.SeoComposition.GetSeoSettings(this); }
		}

		///<summary>
		/// Data Hub Query: An optional query which pulls links from the data hub.  If no data hub query is authored or no items are found from the data hub query then no links will be displayed.
		///</summary>
		[ImplementPropertyType("sidebarDataHubQuery")]
		public string SidebarDataHubQuery
		{
			get { return JNCC.PublicWebsite.Core.Models.SidebarComposition.GetSidebarDataHubQuery(this); }
		}

		///<summary>
		/// Primary Call To Action Button: Link & Text for an optional Call to Action button.  This could be various purposes, for example "Get in Touch" or "Download Data".
		///</summary>
		[ImplementPropertyType("sidebarPrimaryCallToActionButton")]
		public RJP.MultiUrlPicker.Models.Link SidebarPrimaryCallToActionButton
		{
			get { return JNCC.PublicWebsite.Core.Models.SidebarComposition.GetSidebarPrimaryCallToActionButton(this); }
		}

		///<summary>
		/// See Also Links: Useful links to other internal & external web pages.
		///</summary>
		[ImplementPropertyType("sidebarSeeAlsoLinks")]
		public IEnumerable<RJP.MultiUrlPicker.Models.Link> SidebarSeeAlsoLinks
		{
			get { return JNCC.PublicWebsite.Core.Models.SidebarComposition.GetSidebarSeeAlsoLinks(this); }
		}
	}
}
