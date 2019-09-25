using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Policy of custom delivery cost.
  /// </summary>
  [DataContract]
  public class DeliverySettingsDtoCustomCost {
    /// <summary>
    /// If true the customer can enter a custom shipping cost.
    /// </summary>
    /// <value>If true the customer can enter a custom shipping cost.</value>
    [DataMember(Name="allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed")]
    public bool? Allowed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeliverySettingsDtoCustomCost {\n");
      sb.Append("  Allowed: ").Append(Allowed).Append("\n");
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
