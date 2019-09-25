using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The rates broken down into detailed categories. Note that this information is only available if the seller has received enough detailed ratings.
  /// </summary>
  [DataContract]
  public class AverageRates {
    /// <summary>
    /// The average value of delivery rate.
    /// </summary>
    /// <value>The average value of delivery rate.</value>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery")]
    public double? Delivery { get; set; }

    /// <summary>
    /// The average value of delivery cost rate.
    /// </summary>
    /// <value>The average value of delivery cost rate.</value>
    [DataMember(Name="deliveryCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryCost")]
    public double? DeliveryCost { get; set; }

    /// <summary>
    /// The average value of description rate.
    /// </summary>
    /// <value>The average value of description rate.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public double? Description { get; set; }

    /// <summary>
    /// The average value of service rate.
    /// </summary>
    /// <value>The average value of service rate.</value>
    [DataMember(Name="service", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "service")]
    public double? Service { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AverageRates {\n");
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
      sb.Append("  DeliveryCost: ").Append(DeliveryCost).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Service: ").Append(Service).Append("\n");
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
