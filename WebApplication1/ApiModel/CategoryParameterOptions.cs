using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// A list of the different options which can be used with this parameter.
  /// </summary>
  [DataContract]
  public class CategoryParameterOptions {
    /// <summary>
    /// Parameters with this option enabled can be used for offer variants creation.
    /// </summary>
    /// <value>Parameters with this option enabled can be used for offer variants creation.</value>
    [DataMember(Name="variantsAllowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variantsAllowed")]
    public bool? VariantsAllowed { get; set; }

    /// <summary>
    /// All offer variants must have the same values in parameters with this option enabled.
    /// </summary>
    /// <value>All offer variants must have the same values in parameters with this option enabled.</value>
    [DataMember(Name="variantsEqual", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variantsEqual")]
    public bool? VariantsEqual { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoryParameterOptions {\n");
      sb.Append("  VariantsAllowed: ").Append(VariantsAllowed).Append("\n");
      sb.Append("  VariantsEqual: ").Append(VariantsEqual).Append("\n");
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
