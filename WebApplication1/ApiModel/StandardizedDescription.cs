using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The description section cannot have more than 40000 bytes in length.
  /// </summary>
  [DataContract]
  public class StandardizedDescription {
    /// <summary>
    /// Gets or Sets Sections
    /// </summary>
    [DataMember(Name="sections", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sections")]
    public List<DescriptionSection> Sections { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StandardizedDescription {\n");
      sb.Append("  Sections: ").Append(Sections).Append("\n");
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
