using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Custom shipping time for the given delivery method (allowed only for methods with shippingRatesConstraints.shippingTime.customizable set to true in the delivery-methods resource). If not set the default shipping time specified in the delivery-methods resource is used.
  /// </summary>
  [DataContract]
  public class ShippingRateShippingTime {
    /// <summary>
    /// ISO 8601 duration format, e.g. P3D for 3 days
    /// </summary>
    /// <value>ISO 8601 duration format, e.g. P3D for 3 days</value>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public string From { get; set; }

    /// <summary>
    /// ISO 8601 duration format, e.g. P3D for 3 days
    /// </summary>
    /// <value>ISO 8601 duration format, e.g. P3D for 3 days</value>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public string To { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingRateShippingTime {\n");
      sb.Append("  From: ").Append(From).Append("\n");
      sb.Append("  To: ").Append(To).Append("\n");
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
