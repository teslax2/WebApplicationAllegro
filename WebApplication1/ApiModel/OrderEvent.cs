using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Order event
  /// </summary>
  [DataContract]
  public class OrderEvent {
    /// <summary>
    /// event id
    /// </summary>
    /// <value>event id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public OrderEventData Order { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public CheckoutFormStatus Type { get; set; }

    /// <summary>
    /// Date when the event occurred
    /// </summary>
    /// <value>Date when the event occurred</value>
    [DataMember(Name="occurredAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occurredAt")]
    public DateTime? OccurredAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderEvent {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
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
