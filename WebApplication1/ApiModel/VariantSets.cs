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
  public class VariantSets {
    /// <summary>
    /// Total number of variant sets matching the query.
    /// </summary>
    /// <value>Total number of variant sets matching the query.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets OfferVariants
    /// </summary>
    [DataMember(Name="offerVariants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerVariants")]
    public List<VariantSetsVariantSet> OfferVariants { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VariantSets {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  OfferVariants: ").Append(OfferVariants).Append("\n");
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
