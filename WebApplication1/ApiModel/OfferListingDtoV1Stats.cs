using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The offer&#x27;s statistics.
  /// </summary>
  [DataContract]
  public class OfferListingDtoV1Stats {
    /// <summary>
    /// The number of users who added this offer to their watch lists.
    /// </summary>
    /// <value>The number of users who added this offer to their watch lists.</value>
    [DataMember(Name="watchersCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "watchersCount")]
    public int? WatchersCount { get; set; }

    /// <summary>
    /// The number of unique users viewing this offer in the past 30 days.
    /// </summary>
    /// <value>The number of unique users viewing this offer in the past 30 days.</value>
    [DataMember(Name="visitsCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visitsCount")]
    public int? VisitsCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferListingDtoV1Stats {\n");
      sb.Append("  WatchersCount: ").Append(WatchersCount).Append("\n");
      sb.Append("  VisitsCount: ").Append(VisitsCount).Append("\n");
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
