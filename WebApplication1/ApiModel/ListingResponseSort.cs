using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Available sort options.
  /// </summary>
  [DataContract]
  public class ListingResponseSort {
    /// <summary>
    /// The query parameter value which should be used for this sorting option.
    /// </summary>
    /// <value>The query parameter value which should be used for this sorting option.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// The sorting option name in Polish.
    /// </summary>
    /// <value>The sorting option name in Polish.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The order label in Polish specifying ascending or descending mode.
    /// </summary>
    /// <value>The order label in Polish specifying ascending or descending mode.</value>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public string Order { get; set; }

    /// <summary>
    /// Indicates whether this sorting option was used in the current request.
    /// </summary>
    /// <value>Indicates whether this sorting option was used in the current request.</value>
    [DataMember(Name="selected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected")]
    public bool? Selected { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListingResponseSort {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Selected: ").Append(Selected).Append("\n");
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
