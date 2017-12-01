//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
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

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Site Settings</summary>
	[PublishedContentModel("siteSettings")]
	public partial class SiteSettings : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "siteSettings";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SiteSettings(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SiteSettings, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Footer information: A text area to appear in the footer
		///</summary>
		[ImplementPropertyType("footerInformation")]
		public string FooterInformation
		{
			get { return this.GetPropertyValue<string>("footerInformation"); }
		}

		///<summary>
		/// Main Links: The main links to appear in the header section
		///</summary>
		[ImplementPropertyType("mainLinks")]
		public Umbraco.Web.Models.RelatedLinks MainLinks
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("mainLinks"); }
		}

		///<summary>
		/// Secondary Links: A secondary area of links to appear in the header section
		///</summary>
		[ImplementPropertyType("secondaryLinks")]
		public Umbraco.Web.Models.RelatedLinks SecondaryLinks
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("secondaryLinks"); }
		}

		///<summary>
		/// Site Name: The name of the site
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}
	}
}
