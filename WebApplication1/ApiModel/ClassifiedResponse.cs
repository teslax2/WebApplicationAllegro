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
  public class ClassifiedResponse {
    /// <summary>
    /// Gets or Sets BasePackage
    /// </summary>
    [DataMember(Name="basePackage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "basePackage")]
    public ClassifiedPackage BasePackage { get; set; }

    /// <summary>
    /// Gets or Sets ExtraPackages
    /// </summary>
    [DataMember(Name="extraPackages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "extraPackages")]
    public List<ClassifiedPackage> ExtraPackages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ClassifiedResponse {\n");
      sb.Append("  BasePackage: ").Append(BasePackage).Append("\n");
      sb.Append("  ExtraPackages: ").Append(ExtraPackages).Append("\n");
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
