using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Additional information about constraints assigned to the category.
  /// </summary>
  [DataContract]
  public class CompatibilityListSupportedCategoriesDtoValidationRules {
    /// <summary>
    /// Maximum number of items allowed on compatibility list.
    /// </summary>
    /// <value>Maximum number of items allowed on compatibility list.</value>
    [DataMember(Name="maxRows", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxRows")]
    public int? MaxRows { get; set; }

    /// <summary>
    /// Maximum length of single item on the list.
    /// </summary>
    /// <value>Maximum length of single item on the list.</value>
    [DataMember(Name="maxCharactersPerLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxCharactersPerLine")]
    public int? MaxCharactersPerLine { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CompatibilityListSupportedCategoriesDtoValidationRules {\n");
      sb.Append("  MaxRows: ").Append(MaxRows).Append("\n");
      sb.Append("  MaxCharactersPerLine: ").Append(MaxCharactersPerLine).Append("\n");
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
