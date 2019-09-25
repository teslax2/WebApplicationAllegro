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
  public class FeePreviewResponse {
    /// <summary>
    /// An array of commissions.
    /// </summary>
    /// <value>An array of commissions.</value>
    [DataMember(Name="commissions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commissions")]
    public List<CommissionResponse> Commissions { get; set; }

    /// <summary>
    /// An array of quotes.
    /// </summary>
    /// <value>An array of quotes.</value>
    [DataMember(Name="quotes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quotes")]
    public List<QuoteResponse> Quotes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeePreviewResponse {\n");
      sb.Append("  Commissions: ").Append(Commissions).Append("\n");
      sb.Append("  Quotes: ").Append(Quotes).Append("\n");
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
