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
  public class WrapperTypeForPreviewConditions {
    /// <summary>
    /// Include in calculation user's active bundles which allow to publish for free offer or use for free promotion options.
    /// </summary>
    /// <value>Include in calculation user's active bundles which allow to publish for free offer or use for free promotion options.</value>
    [DataMember(Name="includeQuotingBundles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeQuotingBundles")]
    public bool? IncludeQuotingBundles { get; set; }

    /// <summary>
    /// Gets or Sets Offer
    /// </summary>
    [DataMember(Name="offer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer")]
    public ParametersForPreviewPrice Offer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WrapperTypeForPreviewConditions {\n");
      sb.Append("  IncludeQuotingBundles: ").Append(IncludeQuotingBundles).Append("\n");
      sb.Append("  Offer: ").Append(Offer).Append("\n");
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
