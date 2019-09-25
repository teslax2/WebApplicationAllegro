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
  public class BadgeApplicationRejectionReason {
    /// <summary>
    /// Code corresponding to the message. For more information visit <a href=\"/badge/#6\" target=\"_blank\">the list of available codes</a>.
    /// </summary>
    /// <value>Code corresponding to the message. For more information visit <a href=\"/badge/#6\" target=\"_blank\">the list of available codes</a>.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// List of messages with rejection reasons.
    /// </summary>
    /// <value>List of messages with rejection reasons.</value>
    [DataMember(Name="messages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messages")]
    public List<BadgeApplicationRejectionReasonMessage> Messages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadgeApplicationRejectionReason {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Messages: ").Append(Messages).Append("\n");
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