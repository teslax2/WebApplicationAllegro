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
  public class Promotion {
    /// <summary>
    /// Gets or Sets Bold
    /// </summary>
    [DataMember(Name="bold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bold")]
    public bool? Bold { get; set; }

    /// <summary>
    /// Gets or Sets DepartmentPage
    /// </summary>
    [DataMember(Name="departmentPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departmentPage")]
    public bool? DepartmentPage { get; set; }

    /// <summary>
    /// Gets or Sets Emphasized
    /// </summary>
    [DataMember(Name="emphasized", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emphasized")]
    public bool? Emphasized { get; set; }

    /// <summary>
    /// Gets or Sets EmphasizedHighlightBoldPackage
    /// </summary>
    [DataMember(Name="emphasizedHighlightBoldPackage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emphasizedHighlightBoldPackage")]
    public bool? EmphasizedHighlightBoldPackage { get; set; }

    /// <summary>
    /// Gets or Sets Highlight
    /// </summary>
    [DataMember(Name="highlight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highlight")]
    public bool? Highlight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Promotion {\n");
      sb.Append("  Bold: ").Append(Bold).Append("\n");
      sb.Append("  DepartmentPage: ").Append(DepartmentPage).Append("\n");
      sb.Append("  Emphasized: ").Append(Emphasized).Append("\n");
      sb.Append("  EmphasizedHighlightBoldPackage: ").Append(EmphasizedHighlightBoldPackage).Append("\n");
      sb.Append("  Highlight: ").Append(Highlight).Append("\n");
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
