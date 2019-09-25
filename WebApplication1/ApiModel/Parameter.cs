using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Offer&#x27;s parameter
  /// </summary>
  [DataContract]
  public class Parameter {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets RangeValue
    /// </summary>
    [DataMember(Name="rangeValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rangeValue")]
    public ParameterRangeValue RangeValue { get; set; }

    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [DataMember(Name="values", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "values")]
    public List<string> Values { get; set; }

    /// <summary>
    /// Gets or Sets ValuesIds
    /// </summary>
    [DataMember(Name="valuesIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valuesIds")]
    public List<string> ValuesIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Parameter {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  RangeValue: ").Append(RangeValue).Append("\n");
      sb.Append("  Values: ").Append(Values).Append("\n");
      sb.Append("  ValuesIds: ").Append(ValuesIds).Append("\n");
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
