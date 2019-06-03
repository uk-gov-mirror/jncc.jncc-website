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
	// Mixin content Type 1122 with alias "globalIncludesComposition"
	/// <summary>Global Includes Composition</summary>
	public partial interface IGlobalIncludesComposition : IPublishedContent
	{
		/// <summary>Global BODY Includes</summary>
		string GlobalBodyIncludes { get; }

		/// <summary>Global HEAD Includes</summary>
		string GlobalHeadIncludes { get; }
	}

	/// <summary>Global Includes Composition</summary>
	[PublishedContentModel("globalIncludesComposition")]
	public partial class GlobalIncludesComposition : PublishedContentModel, IGlobalIncludesComposition
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "globalIncludesComposition";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GlobalIncludesComposition(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GlobalIncludesComposition, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Global BODY Includes: Authored code includes which will appear on each page and will be rendered at the end of the BODY tag in the HTML.  This is useful for adding tracking code. Styling should not be authored here and should instead be authored in the head.  This should be edited by administrators only.
		///</summary>
		[ImplementPropertyType("globalBodyIncludes")]
		public string GlobalBodyIncludes
		{
			get { return GetGlobalBodyIncludes(this); }
		}

		/// <summary>Static getter for Global BODY Includes</summary>
		public static string GetGlobalBodyIncludes(IGlobalIncludesComposition that) { return that.GetPropertyValue<string>("globalBodyIncludes"); }

		///<summary>
		/// Global HEAD Includes: Authored code includes which will appear on each page and will be rendered at the end of the HEAD tag in the HTML.  This is useful for adding tracking code and style elements.  This should be edited by administrators only.
		///</summary>
		[ImplementPropertyType("globalHeadIncludes")]
		public string GlobalHeadIncludes
		{
			get { return GetGlobalHeadIncludes(this); }
		}

		/// <summary>Static getter for Global HEAD Includes</summary>
		public static string GetGlobalHeadIncludes(IGlobalIncludesComposition that) { return that.GetPropertyValue<string>("globalHeadIncludes"); }
	}
}
