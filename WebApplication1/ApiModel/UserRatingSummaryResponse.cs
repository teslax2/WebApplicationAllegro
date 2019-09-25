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
  public class UserRatingSummaryResponse {
    /// <summary>
    /// Gets or Sets AverageRates
    /// </summary>
    [DataMember(Name="averageRates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "averageRates")]
    public AverageRates AverageRates { get; set; }

    /// <summary>
    /// Gets or Sets NotRecommended
    /// </summary>
    [DataMember(Name="notRecommended", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notRecommended")]
    public UserRatingSummaryResponseNotRecommended NotRecommended { get; set; }

    /// <summary>
    /// Gets or Sets Recommended
    /// </summary>
    [DataMember(Name="recommended", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommended")]
    public UserRatingSummaryResponseRecommended Recommended { get; set; }

    /// <summary>
    /// Percentage of unique buyers recommending the seller.
    /// </summary>
    /// <value>Percentage of unique buyers recommending the seller.</value>
    [DataMember(Name="recommendedPercentage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommendedPercentage")]
    public string RecommendedPercentage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRatingSummaryResponse {\n");
      sb.Append("  AverageRates: ").Append(AverageRates).Append("\n");
      sb.Append("  NotRecommended: ").Append(NotRecommended).Append("\n");
      sb.Append("  Recommended: ").Append(Recommended).Append("\n");
      sb.Append("  RecommendedPercentage: ").Append(RecommendedPercentage).Append("\n");
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
