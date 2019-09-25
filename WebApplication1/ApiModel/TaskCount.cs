using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Offers updates summary
  /// </summary>
  [DataContract]
  public class TaskCount {
    /// <summary>
    /// Current number of failed offers updates
    /// </summary>
    /// <value>Current number of failed offers updates</value>
    [DataMember(Name="failed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "failed")]
    public int? Failed { get; set; }

    /// <summary>
    /// Current number of success offers updates
    /// </summary>
    /// <value>Current number of success offers updates</value>
    [DataMember(Name="success", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "success")]
    public int? Success { get; set; }

    /// <summary>
    /// Total number of scheduled offers updates
    /// </summary>
    /// <value>Total number of scheduled offers updates</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaskCount {\n");
      sb.Append("  Failed: ").Append(Failed).Append("\n");
      sb.Append("  Success: ").Append(Success).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
