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
  public class ChangePrice {
    /// <summary>
    /// The unique command id provided in the input.
    /// </summary>
    /// <value>The unique command id provided in the input.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Input
    /// </summary>
    [DataMember(Name="input", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "input")]
    public ChangePriceInput Input { get; set; }

    /// <summary>
    /// Gets or Sets Output
    /// </summary>
    [DataMember(Name="output", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "output")]
    public CommandOutput Output { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChangePrice {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Input: ").Append(Input).Append("\n");
      sb.Append("  Output: ").Append(Output).Append("\n");
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
