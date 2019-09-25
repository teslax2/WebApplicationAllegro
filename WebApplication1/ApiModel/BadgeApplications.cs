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
  public class BadgeApplications {
    /// <summary>
    /// Gets or Sets _BadgeApplications
    /// </summary>
    [DataMember(Name="badgeApplications", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "badgeApplications")]
    public List<BadgeApplication> _BadgeApplications { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadgeApplications {\n");
      sb.Append("  _BadgeApplications: ").Append(_BadgeApplications).Append("\n");
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
