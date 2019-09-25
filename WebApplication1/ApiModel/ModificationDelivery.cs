using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Contains shipping rates to change
  /// </summary>
  [DataContract]
  public class ModificationDelivery {
    /// <summary>
    /// Gets or Sets ShippingRates
    /// </summary>
    [DataMember(Name="shippingRates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingRates")]
    public ShippingRates ShippingRates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModificationDelivery {\n");
      sb.Append("  ShippingRates: ").Append(ShippingRates).Append("\n");
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
