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
  public class CheckoutFormDeliveryReference {
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public CheckoutFormDeliveryAddress Address { get; set; }

    /// <summary>
    /// Gets or Sets Method
    /// </summary>
    [DataMember(Name="method", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "method")]
    public CheckoutFormDeliveryMethod Method { get; set; }

    /// <summary>
    /// Gets or Sets PickupPoint
    /// </summary>
    [DataMember(Name="pickupPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickupPoint")]
    public CheckoutFormDeliveryPickupPoint PickupPoint { get; set; }

    /// <summary>
    /// Gets or Sets Cost
    /// </summary>
    [DataMember(Name="cost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cost")]
    public Price Cost { get; set; }

    /// <summary>
    /// Gets or Sets Time
    /// </summary>
    [DataMember(Name="time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "time")]
    public CheckoutFormDeliveryTime Time { get; set; }

    /// <summary>
    /// Buyer used a SMART option
    /// </summary>
    /// <value>Buyer used a SMART option</value>
    [DataMember(Name="smart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "smart")]
    public bool? Smart { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutFormDeliveryReference {\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Method: ").Append(Method).Append("\n");
      sb.Append("  PickupPoint: ").Append(PickupPoint).Append("\n");
      sb.Append("  Cost: ").Append(Cost).Append("\n");
      sb.Append("  Time: ").Append(Time).Append("\n");
      sb.Append("  Smart: ").Append(Smart).Append("\n");
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
