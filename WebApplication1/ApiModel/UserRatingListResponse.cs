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
  public class UserRatingListResponse {
    /// <summary>
    /// List of ratings that match requested filter. Empty when no rating matched.
    /// </summary>
    /// <value>List of ratings that match requested filter. Empty when no rating matched.</value>
    [DataMember(Name="ratings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ratings")]
    public List<UserRating> Ratings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRatingListResponse {\n");
      sb.Append("  Ratings: ").Append(Ratings).Append("\n");
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
