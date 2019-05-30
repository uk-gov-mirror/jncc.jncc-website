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
	// Mixin content Type 1240 with alias "scienceCategorySectionSubSectionsSchemaComposition"
	/// <summary>Science Category Section Sub Sections Schema Composition</summary>
	public partial interface IScienceCategorySectionSubSectionsSchemaComposition : IPublishedContent
	{
		/// <summary>Sub Sections</summary>
		IEnumerable<IPublishedContent> SubSections { get; }
	}

	/// <summary>Science Category Section Sub Sections Schema Composition</summary>
	[PublishedContentModel("scienceCategorySectionSubSectionsSchemaComposition")]
	public partial class ScienceCategorySectionSubSectionsSchemaComposition : PublishedContentModel, IScienceCategorySectionSubSectionsSchemaComposition
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "scienceCategorySectionSubSectionsSchemaComposition";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ScienceCategorySectionSubSectionsSchemaComposition(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ScienceCategorySectionSubSectionsSchemaComposition, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Sub Sections: Optional sub sections which will be rendered below the content of this section.
		///</summary>
		[ImplementPropertyType("subSections")]
		public IEnumerable<IPublishedContent> SubSections
		{
			get { return GetSubSections(this); }
		}

		/// <summary>Static getter for Sub Sections</summary>
		public static IEnumerable<IPublishedContent> GetSubSections(IScienceCategorySectionSubSectionsSchemaComposition that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("subSections"); }
	}
}
