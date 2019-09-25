using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// This section describes the selling format and prices.
  /// </summary>
  [DataContract]
  public class OfferSellingMode {
    /// <summary>
    /// Gets or Sets Format
    /// </summary>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public SellingModeFormat Format { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public OfferPrice Price { get; set; }

    /// <summary>
    /// Gets or Sets FixedPrice
    /// </summary>
    [DataMember(Name="fixedPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixedPrice")]
    public OfferFixedPrice FixedPrice { get; set; }

    /// <summary>
    /// Popularity of the offer for *BUY_NOW* selling format.
    /// </summary>
    /// <value>Popularity of the offer for *BUY_NOW* selling format.</value>
    [DataMember(Name="popularity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "popularity")]
    public int? Popularity { get; set; }

    /// <summary>
    /// Number of bidders for *AUCTION* selling format.
    /// </summary>
    /// <value>Number of bidders for *AUCTION* selling format.</value>
    [DataMember(Name="bidCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bidCount")]
    public int? BidCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferSellingMode {\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  FixedPrice: ").Append(FixedPrice).Append("\n");
      sb.Append("  Popularity: ").Append(Popularity).Append("\n");
      sb.Append("  BidCount: ").Append(BidCount).Append("\n");
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
