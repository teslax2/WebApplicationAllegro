using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// List of badges
  /// </summary>
  [DataContract]
  public class BadgesList {
    /// <summary>
    /// Gets or Sets Badges
    /// </summary>
    [DataMember(Name="badges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "badges")]
    public List<Badge> Badges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadgesList {\n");
      sb.Append("  Badges: ").Append(Badges).Append("\n");
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
