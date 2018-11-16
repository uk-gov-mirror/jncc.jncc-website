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
	// Mixin content Type 1059 with alias "pageHeroComposition"
	/// <summary>Page Hero Composition</summary>
	public partial interface IPageHeroComposition : IPublishedContent
	{
		/// <summary>Headline</summary>
		string Headline { get; }

		/// <summary>Hero Image</summary>
		IEnumerable<IPublishedContent> HeroImage { get; }
	}

	/// <summary>Page Hero Composition</summary>
	[PublishedContentModel("pageHeroComposition")]
	public partial class PageHeroComposition : PublishedContentModel, IPageHeroComposition
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "pageHeroComposition";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PageHeroComposition(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageHeroComposition, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Headline: A headline that appears above the main content of the page.  If no value is provided the page name will be used instead.  If a hero image is also provided then this headline appears over the hero image. Otherwise it appears just above the main content.
		///</summary>
		[ImplementPropertyType("headline")]
		public string Headline
		{
			get { return GetHeadline(this); }
		}

		/// <summary>Static getter for Headline</summary>
		public static string GetHeadline(IPageHeroComposition that) { return that.GetPropertyValue<string>("headline"); }

		///<summary>
		/// Hero Image: The hero image which is displayed above the main content of the page.
		///</summary>
		[ImplementPropertyType("heroImage")]
		public IEnumerable<IPublishedContent> HeroImage
		{
			get { return GetHeroImage(this); }
		}

		/// <summary>Static getter for Hero Image</summary>
		public static IEnumerable<IPublishedContent> GetHeroImage(IPageHeroComposition that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("heroImage"); }
	}
}
