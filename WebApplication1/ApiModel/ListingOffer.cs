using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ListingOffer {
    /// <summary>
    /// The offer ID.
    /// </summary>
    /// <value>The offer ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The title of the offer.
    /// </summary>
    /// <value>The title of the offer.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Seller
    /// </summary>
    [DataMember(Name="seller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seller")]
    public OfferSeller Seller { get; set; }

    /// <summary>
    /// Gets or Sets Promotion
    /// </summary>
    [DataMember(Name="promotion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promotion")]
    public OfferPromotion Promotion { get; set; }

    /// <summary>
    /// Gets or Sets Delivery
    /// </summary>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery")]
    public OfferDelivery Delivery { get; set; }

    /// <summary>
    /// The gallery of images. Only the URL of the original sized image is provided. The first image represents the thumbnail image used on listing.
    /// </summary>
    /// <value>The gallery of images. Only the URL of the original sized image is provided. The first image represents the thumbnail image used on listing.</value>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<OfferImages> Images { get; set; }

    /// <summary>
    /// Gets or Sets SellingMode
    /// </summary>
    [DataMember(Name="sellingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sellingMode")]
    public OfferSellingMode SellingMode { get; set; }

    /// <summary>
    /// Gets or Sets Stock
    /// </summary>
    [DataMember(Name="stock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stock")]
    public OfferStock Stock { get; set; }

    /// <summary>
    /// Gets or Sets Vendor
    /// </summary>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public OfferVendor Vendor { get; set; }

    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public OfferCategory Category { get; set; }

    /// <summary>
    /// Gets or Sets Publication
    /// </summary>
    [DataMember(Name="publication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publication")]
    public OfferPublication Publication { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListingOffer {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Seller: ").Append(Seller).Append("\n");
      sb.Append("  Promotion: ").Append(Promotion).Append("\n");
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  SellingMode: ").Append(SellingMode).Append("\n");
      sb.Append("  Stock: ").Append(Stock).Append("\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Publication: ").Append(Publication).Append("\n");
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
