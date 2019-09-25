using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Additional information about offers in auction format.
  /// </summary>
  [DataContract]
  public class OfferListingDtoV1SaleInfo {
    /// <summary>
    /// Gets or Sets CurrentPrice
    /// </summary>
    [DataMember(Name="currentPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPrice")]
    public CurrentPrice CurrentPrice { get; set; }

    /// <summary>
    /// The number of bidders.
    /// </summary>
    /// <value>The number of bidders.</value>
    [DataMember(Name="biddersCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "biddersCount")]
    public int? BiddersCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferListingDtoV1SaleInfo {\n");
      sb.Append("  CurrentPrice: ").Append(CurrentPrice).Append("\n");
      sb.Append("  BiddersCount: ").Append(BiddersCount).Append("\n");
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
