using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Information on the offer&#x27;s publication status and dates.
  /// </summary>
  [DataContract]
  public class OfferListingDtoV1Publication {
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public OfferStatus Status { get; set; }

    /// <summary>
    /// The date and time of activation in UTC for a planned listing.
    /// </summary>
    /// <value>The date and time of activation in UTC for a planned listing.</value>
    [DataMember(Name="startingAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startingAt")]
    public string StartingAt { get; set; }

    /// <summary>
    /// The actual date and time of activation in UTC.
    /// </summary>
    /// <value>The actual date and time of activation in UTC.</value>
    [DataMember(Name="startedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startedAt")]
    public string StartedAt { get; set; }

    /// <summary>
    /// The date and time of a planned ending in UTC.
    /// </summary>
    /// <value>The date and time of a planned ending in UTC.</value>
    [DataMember(Name="endingAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endingAt")]
    public string EndingAt { get; set; }

    /// <summary>
    /// The actual date and time of last ending in UTC.
    /// </summary>
    /// <value>The actual date and time of last ending in UTC.</value>
    [DataMember(Name="endedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endedAt")]
    public string EndedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferListingDtoV1Publication {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  StartingAt: ").Append(StartingAt).Append("\n");
      sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
      sb.Append("  EndingAt: ").Append(EndingAt).Append("\n");
      sb.Append("  EndedAt: ").Append(EndedAt).Append("\n");
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
