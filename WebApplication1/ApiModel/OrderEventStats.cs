using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Event statistics, currently contains only basic information about the latest event.
  /// </summary>
  [DataContract]
  public class OrderEventStats {
    /// <summary>
    /// Gets or Sets LatestEvent
    /// </summary>
    [DataMember(Name="latestEvent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latestEvent")]
    public LatestOrderEvent LatestEvent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderEventStats {\n");
      sb.Append("  LatestEvent: ").Append(LatestEvent).Append("\n");
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
