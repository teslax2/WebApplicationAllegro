using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The data of an event.
  /// </summary>
  [DataContract]
  public class SellerOfferBaseEvent {
    /// <summary>
    /// The ID of the event. It can be used in the `from` parameter of the query.
    /// </summary>
    /// <value>The ID of the event. It can be used in the `from` parameter of the query.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The date and time when the event occurred, provided in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.
    /// </summary>
    /// <value>The date and time when the event occurred, provided in [ISO 8601](https://en.wikipedia.org/wiki/ISO_8601) format.</value>
    [DataMember(Name="occurredAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occurredAt")]
    public DateTime? OccurredAt { get; set; }

    /// <summary>
    /// The type of the event.
    /// </summary>
    /// <value>The type of the event.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SellerOfferBaseEvent {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OccurredAt: ").Append(OccurredAt).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
