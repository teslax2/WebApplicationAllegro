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
  public class OffersSearchResultDto {
    /// <summary>
    /// The list of seller's offers matching the request's criteria.
    /// </summary>
    /// <value>The list of seller's offers matching the request's criteria.</value>
    [DataMember(Name="offers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offers")]
    public List<OfferListingDto> Offers { get; set; }

    /// <summary>
    /// Number of offers in the search result.
    /// </summary>
    /// <value>Number of offers in the search result.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// The total number of offers matching the request's criteria.
    /// </summary>
    /// <value>The total number of offers matching the request's criteria.</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OffersSearchResultDto {\n");
      sb.Append("  Offers: ").Append(Offers).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
