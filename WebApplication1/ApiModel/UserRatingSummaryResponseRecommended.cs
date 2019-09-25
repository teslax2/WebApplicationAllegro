using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Summary of data concerning users that recommend the seller.
  /// </summary>
  [DataContract]
  public class UserRatingSummaryResponseRecommended {
    /// <summary>
    /// Total number of positive feedbacks received.
    /// </summary>
    /// <value>Total number of positive feedbacks received.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public long? Total { get; set; }

    /// <summary>
    /// Number of unique users.
    /// </summary>
    /// <value>Number of unique users.</value>
    [DataMember(Name="unique", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unique")]
    public long? Unique { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRatingSummaryResponseRecommended {\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Unique: ").Append(Unique).Append("\n");
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
