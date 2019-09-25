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
  public class Removal {
    /// <summary>
    /// Date until a removal request can be submitted in ISO 8601 format
    /// </summary>
    /// <value>Date until a removal request can be submitted in ISO 8601 format</value>
    [DataMember(Name="possibleTo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "possibleTo")]
    public DateTime? PossibleTo { get; set; }

    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "request")]
    public RemovalRequest Request { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Removal {\n");
      sb.Append("  PossibleTo: ").Append(PossibleTo).Append("\n");
      sb.Append("  Request: ").Append(Request).Append("\n");
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
