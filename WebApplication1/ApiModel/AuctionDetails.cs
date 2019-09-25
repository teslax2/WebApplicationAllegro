using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Auction details.
  /// </summary>
  [DataContract]
  public class AuctionDetails {
    /// <summary>
    /// Gets or Sets CurrentPrice
    /// </summary>
    [DataMember(Name="currentPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentPrice")]
    public CurrentPrice CurrentPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuctionDetails {\n");
      sb.Append("  CurrentPrice: ").Append(CurrentPrice).Append("\n");
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
