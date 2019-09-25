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
  public class AdditionalEmailsResponse {
    /// <summary>
    /// Gets or Sets AdditionalEmails
    /// </summary>
    [DataMember(Name="additional-emails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additional-emails")]
    public List<AdditionalEmail> AdditionalEmails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalEmailsResponse {\n");
      sb.Append("  AdditionalEmails: ").Append(AdditionalEmails).Append("\n");
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
