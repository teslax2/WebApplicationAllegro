using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// A list of the different options which can be used with this category.
  /// </summary>
  [DataContract]
  public class CategoryOptionsDto {
    /// <summary>
    /// Indicates whether offers of type ADVERTISEMENT can be listed in this category.
    /// </summary>
    /// <value>Indicates whether offers of type ADVERTISEMENT can be listed in this category.</value>
    [DataMember(Name="advertisement", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advertisement")]
    public bool? Advertisement { get; set; }

    /// <summary>
    /// Indicates whether advertisements listed in this category must have a price given. If the value is `true` then you don't have to provide a price when listing an advertisement in this category.
    /// </summary>
    /// <value>Indicates whether advertisements listed in this category must have a price given. If the value is `true` then you don't have to provide a price when listing an advertisement in this category.</value>
    [DataMember(Name="advertisementPriceOptional", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "advertisementPriceOptional")]
    public bool? AdvertisementPriceOptional { get; set; }

    /// <summary>
    /// Indicates whether you can combine offers from this category into variant sets based on the color and pattern.
    /// </summary>
    /// <value>Indicates whether you can combine offers from this category into variant sets based on the color and pattern.</value>
    [DataMember(Name="variantsByColorPatternAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variantsByColorPatternAllowed")]
    public bool? VariantsByColorPatternAllowed { get; set; }

    /// <summary>
    /// Information whether the category supports assigning offers to a product.
    /// </summary>
    /// <value>Information whether the category supports assigning offers to a product.</value>
    [DataMember(Name="offersWithProductPublicationEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offersWithProductPublicationEnabled")]
    public bool? OffersWithProductPublicationEnabled { get; set; }

    /// <summary>
    /// Indicates whether the category supports creating products.
    /// </summary>
    /// <value>Indicates whether the category supports creating products.</value>
    [DataMember(Name="productCreationEnabled", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productCreationEnabled")]
    public bool? ProductCreationEnabled { get; set; }

    /// <summary>
    /// Indicates whether at least one EAN is required when creating products.
    /// </summary>
    /// <value>Indicates whether at least one EAN is required when creating products.</value>
    [DataMember(Name="productEANRequired", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productEANRequired")]
    public bool? ProductEANRequired { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoryOptionsDto {\n");
      sb.Append("  Advertisement: ").Append(Advertisement).Append("\n");
      sb.Append("  AdvertisementPriceOptional: ").Append(AdvertisementPriceOptional).Append("\n");
      sb.Append("  VariantsByColorPatternAllowed: ").Append(VariantsByColorPatternAllowed).Append("\n");
      sb.Append("  OffersWithProductPublicationEnabled: ").Append(OffersWithProductPublicationEnabled).Append("\n");
      sb.Append("  ProductCreationEnabled: ").Append(ProductCreationEnabled).Append("\n");
      sb.Append("  ProductEANRequired: ").Append(ProductEANRequired).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
