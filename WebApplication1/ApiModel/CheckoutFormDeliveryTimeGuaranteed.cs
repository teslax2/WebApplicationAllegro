using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Guaranteed date when first delivery attempt takes place. This is always filled for X-press Couriers delivery method.
  /// </summary>
  [DataContract]
  public class CheckoutFormDeliveryTimeGuaranteed {
    /// <summary>
    /// ISO date when the earliest delivery attempt can take place.
    /// </summary>
    /// <value>ISO date when the earliest delivery attempt can take place.</value>
    [DataMember(Name="from", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "from")]
    public DateTime? From { get; set; }

    /// <summary>
    /// ISO date when the latest delivery attempt can take place.
    /// </summary>
    /// <value>ISO date when the latest delivery attempt can take place.</value>
    [DataMember(Name="to", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "to")]
    public DateTime? To { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutFormDeliveryTimeGuaranteed {\n");
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
