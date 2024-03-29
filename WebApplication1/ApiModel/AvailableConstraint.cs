using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AvailableConstraint {
    /// <summary>
    /// One of the type COUNTRY_SAME_QUANTITY or COUNTRY_DELIVERY_SAME_QUANTITY
    /// </summary>
    /// <value>One of the type COUNTRY_SAME_QUANTITY or COUNTRY_DELIVERY_SAME_QUANTITY</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets AvailableDeliveryMethods
    /// </summary>
    [DataMember(Name="availableDeliveryMethods", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableDeliveryMethods")]
    public List<string> AvailableDeliveryMethods { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AvailableConstraint {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  AvailableDeliveryMethods: ").Append(AvailableDeliveryMethods).Append("\n");
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
