using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Required by DISCOUNT and SOURCING campaign.
  /// </summary>
  [DataContract]
  public class BadgeApplicationPrices {
    /// <summary>
    /// Gets or Sets Market
    /// </summary>
    [DataMember(Name="market", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "market")]
    public BadgeApplicationMarketPrice Market { get; set; }

    /// <summary>
    /// Gets or Sets Bargain
    /// </summary>
    [DataMember(Name="bargain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bargain")]
    public BadgeApplicationBargainPrice Bargain { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadgeApplicationPrices {\n");
      sb.Append("  Market: ").Append(Market).Append("\n");
      sb.Append("  Bargain: ").Append(Bargain).Append("\n");
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
