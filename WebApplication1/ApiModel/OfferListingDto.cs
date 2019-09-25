using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// An offer.
  /// </summary>
  [DataContract]
  public class OfferListingDto {
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
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public OfferCategory Category { get; set; }

    /// <summary>
    /// Gets or Sets PrimaryImage
    /// </summary>
    [DataMember(Name="primaryImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "primaryImage")]
    public OfferListingDtoImage PrimaryImage { get; set; }

    /// <summary>
    /// Gets or Sets SellingMode
    /// </summary>
    [DataMember(Name="sellingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sellingMode")]
    public SellingMode SellingMode { get; set; }

    /// <summary>
    /// Gets or Sets SaleInfo
    /// </summary>
    [DataMember(Name="saleInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "saleInfo")]
    public OfferListingDtoV1SaleInfo SaleInfo { get; set; }

    /// <summary>
    /// Gets or Sets Stock
    /// </summary>
    [DataMember(Name="stock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stock")]
    public OfferListingDtoV1Stock Stock { get; set; }

    /// <summary>
    /// Gets or Sets Stats
    /// </summary>
    [DataMember(Name="stats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stats")]
    public OfferListingDtoV1Stats Stats { get; set; }

    /// <summary>
    /// Gets or Sets Publication
    /// </summary>
    [DataMember(Name="publication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publication")]
    public OfferListingDtoV1Publication Publication { get; set; }

    /// <summary>
    /// Gets or Sets AfterSalesServices
    /// </summary>
    [DataMember(Name="afterSalesServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "afterSalesServices")]
    public AfterSalesServices AfterSalesServices { get; set; }

    /// <summary>
    /// Gets or Sets AdditionalServices
    /// </summary>
    [DataMember(Name="additionalServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalServices")]
    public OfferAdditionalServices AdditionalServices { get; set; }

    /// <summary>
    /// Gets or Sets External
    /// </summary>
    [DataMember(Name="external", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external")]
    public ExternalId External { get; set; }

    /// <summary>
    /// Gets or Sets Delivery
    /// </summary>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery")]
    public OfferListingDtoV1Delivery Delivery { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferListingDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  PrimaryImage: ").Append(PrimaryImage).Append("\n");
      sb.Append("  SellingMode: ").Append(SellingMode).Append("\n");
      sb.Append("  SaleInfo: ").Append(SaleInfo).Append("\n");
      sb.Append("  Stock: ").Append(Stock).Append("\n");
      sb.Append("  Stats: ").Append(Stats).Append("\n");
      sb.Append("  Publication: ").Append(Publication).Append("\n");
      sb.Append("  AfterSalesServices: ").Append(AfterSalesServices).Append("\n");
      sb.Append("  AdditionalServices: ").Append(AdditionalServices).Append("\n");
      sb.Append("  External: ").Append(External).Append("\n");
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
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
