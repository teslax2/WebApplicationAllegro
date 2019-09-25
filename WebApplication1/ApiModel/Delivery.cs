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
  public class Delivery {
    /// <summary>
    /// Gets or Sets AdditionalInfo
    /// </summary>
    [DataMember(Name="additionalInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalInfo")]
    public string AdditionalInfo { get; set; }

    /// <summary>
    /// Handling time, ISO 8601 duration format
    /// </summary>
    /// <value>Handling time, ISO 8601 duration format</value>
    [DataMember(Name="handlingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "handlingTime")]
    public string HandlingTime { get; set; }

    /// <summary>
    /// Shipment date, Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ
    /// </summary>
    /// <value>Shipment date, Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ</value>
    [DataMember(Name="shipmentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shipmentDate")]
    public DateTime? ShipmentDate { get; set; }

    /// <summary>
    /// Gets or Sets ShippingRates
    /// </summary>
    [DataMember(Name="shippingRates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingRates")]
    public JustId ShippingRates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Delivery {\n");
      sb.Append("  AdditionalInfo: ").Append(AdditionalInfo).Append("\n");
      sb.Append("  HandlingTime: ").Append(HandlingTime).Append("\n");
      sb.Append("  ShipmentDate: ").Append(ShipmentDate).Append("\n");
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
