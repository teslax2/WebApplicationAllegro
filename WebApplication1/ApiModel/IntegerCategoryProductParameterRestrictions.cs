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
  public class IntegerCategoryProductParameterRestrictions {
    /// <summary>
    /// The minimum value of this parameter.
    /// </summary>
    /// <value>The minimum value of this parameter.</value>
    [DataMember(Name="min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min")]
    public int? Min { get; set; }

    /// <summary>
    /// The maximum value of this parameter.
    /// </summary>
    /// <value>The maximum value of this parameter.</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max")]
    public int? Max { get; set; }

    /// <summary>
    /// Indicates whether this is a range parameter. If this is `true`, then you have to provide two values for this parameter - `from` and `to`. Both these values have to be between the `min` and `max`.
    /// </summary>
    /// <value>Indicates whether this is a range parameter. If this is `true`, then you have to provide two values for this parameter - `from` and `to`. Both these values have to be between the `min` and `max`.</value>
    [DataMember(Name="range", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "range")]
    public bool? Range { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class IntegerCategoryProductParameterRestrictions {\n");
      sb.Append("  Min: ").Append(Min).Append("\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
      sb.Append("  Range: ").Append(Range).Append("\n");
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
