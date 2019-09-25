using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Contains list of task results
  /// </summary>
  [DataContract]
  public class TaskReport {
    /// <summary>
    /// List of task results
    /// </summary>
    /// <value>List of task results</value>
    [DataMember(Name="tasks", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tasks")]
    public List<CommandTask> Tasks { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TaskReport {\n");
      sb.Append("  Tasks: ").Append(Tasks).Append("\n");
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
