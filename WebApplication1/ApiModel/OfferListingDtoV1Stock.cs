using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Information on the offer&#x27;s stock.
  /// </summary>
  [DataContract]
  public class OfferListingDtoV1Stock {
    /// <summary>
    /// The available stock value.
    /// </summary>
    /// <value>The available stock value.</value>
    [DataMember(Name="available", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "available")]
    public int? Available { get; set; }

    /// <summary>
    /// The number of sold items in the last 30 days.
    /// </summary>
    /// <value>The number of sold items in the last 30 days.</value>
    [DataMember(Name="sold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sold")]
    public int? Sold { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferListingDtoV1Stock {\n");
      sb.Append("  Available: ").Append(Available).Append("\n");
      sb.Append("  Sold: ").Append(Sold).Append("\n");
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
