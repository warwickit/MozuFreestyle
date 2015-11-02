
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Codezu.     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;


namespace Mozu.Api.Contracts.ProductAdmin
{
		///
		///	The actual vocabulary value of the attribute that exists as a part of the product type.
		///
		public class AttributeVocabularyValueInProductType
		{
			///
			///Defines the intended display of this attribute in the storefront. Options include Drop Down, Image Picker, and Radio Buttons.
			///
			public AttributeVocabularyValueDisplayInfo DisplayInfo { get; set; }

			///
			///Integer that represents the sequence order of the attribute.
			///
			public int? Order { get; set; }

			///
			///The value of a property, used by numerous objects within Mozu including facets, attributes, products, localized content, metadata, capabilities (Mozu and third-party), location inventory adjustment, and more. The value may be a string, integer, or double. Validation may be run against the entered and saved values depending on the object type.
			///
			public object Value { get; set; }

			///
			///Navigates vocabulary value details for an attribute defined for a product type.
			///
			public AttributeVocabularyValue VocabularyValueDetail { get; set; }

		}

}