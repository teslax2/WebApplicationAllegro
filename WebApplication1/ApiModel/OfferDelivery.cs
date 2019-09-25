using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Information about shipping options for the offer.
  /// </summary>
  [DataContract]
  public class OfferDelivery {
    /// <summary>
    /// Indicates whether the offer has free shipping option.
    /// </summary>
    /// <value>Indicates whether the offer has free shipping option.</value>
    [DataMember(Name="availableForFree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableForFree")]
    public bool? AvailableForFree { get; set; }

    /// <summary>
    /// Gets or Sets LowestPrice
    /// </summary>
    [DataMember(Name="lowestPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowestPrice")]
    public OfferLowestPrice LowestPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferDelivery {\n");
      sb.Append("  AvailableForFree: ").Append(AvailableForFree).Append("\n");
      sb.Append("  LowestPrice: ").Append(LowestPrice).Append("\n");
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
