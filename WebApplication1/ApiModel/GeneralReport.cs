using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Command execution summary
  /// </summary>
  [DataContract]
  public class GeneralReport {
    /// <summary>
    /// Command ID
    /// </summary>
    /// <value>Command ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets TaskCount
    /// </summary>
    [DataMember(Name="taskCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taskCount")]
    public TaskCount TaskCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GeneralReport {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  TaskCount: ").Append(TaskCount).Append("\n");
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
