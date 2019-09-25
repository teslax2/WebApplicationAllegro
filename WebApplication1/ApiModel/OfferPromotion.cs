using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Information about promotion options for the item.
  /// </summary>
  [DataContract]
  public class OfferPromotion {
    /// <summary>
    /// Indicates whether the offer is promoted.
    /// </summary>
    /// <value>Indicates whether the offer is promoted.</value>
    [DataMember(Name="emphasized", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "emphasized")]
    public bool? Emphasized { get; set; }

    /// <summary>
    /// Indicates whether the offer has bold title option.
    /// </summary>
    /// <value>Indicates whether the offer has bold title option.</value>
    [DataMember(Name="bold", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bold")]
    public bool? Bold { get; set; }

    /// <summary>
    /// Indicates whether the offer has highlight option.
    /// </summary>
    /// <value>Indicates whether the offer has highlight option.</value>
    [DataMember(Name="highlight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highlight")]
    public bool? Highlight { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferPromotion {\n");
      sb.Append("  Emphasized: ").Append(Emphasized).Append("\n");
      sb.Append("  Bold: ").Append(Bold).Append("\n");
      sb.Append("  Highlight: ").Append(Highlight).Append("\n");
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
