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
  public class AuthError {
    /// <summary>
    /// Authorization error code
    /// </summary>
    /// <value>Authorization error code</value>
    [DataMember(Name="error", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error")]
    public string Error { get; set; }

    /// <summary>
    /// Authorization error message
    /// </summary>
    /// <value>Authorization error message</value>
    [DataMember(Name="error_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "error_description")]
    public string ErrorDescription { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AuthError {\n");
      sb.Append("  Error: ").Append(Error).Append("\n");
      sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
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
