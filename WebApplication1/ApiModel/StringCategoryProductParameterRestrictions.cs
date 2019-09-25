using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The restrictions on values of this parameter.
  /// </summary>
  [DataContract]
  public class StringCategoryProductParameterRestrictions {
    /// <summary>
    /// The minimum length of the parameter value.
    /// </summary>
    /// <value>The minimum length of the parameter value.</value>
    [DataMember(Name="minLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minLength")]
    public int? MinLength { get; set; }

    /// <summary>
    /// The maximum length of the parameter value.
    /// </summary>
    /// <value>The maximum length of the parameter value.</value>
    [DataMember(Name="maxLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLength")]
    public int? MaxLength { get; set; }

    /// <summary>
    /// Indicates how many different values can be provided for this parameter.
    /// </summary>
    /// <value>Indicates how many different values can be provided for this parameter.</value>
    [DataMember(Name="allowedNumberOfValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedNumberOfValues")]
    public int? AllowedNumberOfValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StringCategoryProductParameterRestrictions {\n");
      sb.Append("  MinLength: ").Append(MinLength).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
      sb.Append("  AllowedNumberOfValues: ").Append(AllowedNumberOfValues).Append("\n");
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
