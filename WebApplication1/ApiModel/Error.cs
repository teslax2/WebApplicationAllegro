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
  public class Error {
    /// <summary>
    /// The error code. You can use this code when contacting us about any problems with our systems.
    /// </summary>
    /// <value>The error code. You can use this code when contacting us about any problems with our systems.</value>
    [DataMember(Name="code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// For some cases, this field provides more details regarding the error. This field can be empty.
    /// </summary>
    /// <value>For some cases, this field provides more details regarding the error. This field can be empty.</value>
    [DataMember(Name="details", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "details")]
    public string Details { get; set; }

    /// <summary>
    /// A message directed to the developer of the program. This message will always be in English and give you some more technical details on what exactly has happened.
    /// </summary>
    /// <value>A message directed to the developer of the program. This message will always be in English and give you some more technical details on what exactly has happened.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// This field will point to a specific field in object if the error is connected to a problem with such specific field. This field can be empty
    /// </summary>
    /// <value>This field will point to a specific field in object if the error is connected to a problem with such specific field. This field can be empty</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// The message that can be presented directly to your user. It will not contain any technical information. This message is translated based on the value of the \"Accept-Language\" header. By default message in English is returned.
    /// </summary>
    /// <value>The message that can be presented directly to your user. It will not contain any technical information. This message is translated based on the value of the \"Accept-Language\" header. By default message in English is returned.</value>
    [DataMember(Name="userMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userMessage")]
    public string UserMessage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Error {\n");
      sb.Append("  Code: ").Append(Code).Append("\n");
      sb.Append("  Details: ").Append(Details).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
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
