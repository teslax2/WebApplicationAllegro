using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Search metadata.
  /// </summary>
  [DataContract]
  public class ListingResponseSearchMeta {
    /// <summary>
    /// The number of results available for navigation. If this number is less than total count, the search criteria (categories, filters, etc.) should be narrowed down to make all results available.
    /// </summary>
    /// <value>The number of results available for navigation. If this number is less than total count, the search criteria (categories, filters, etc.) should be narrowed down to make all results available.</value>
    [DataMember(Name="availableCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "availableCount")]
    public int? AvailableCount { get; set; }

    /// <summary>
    /// The total number of search results with given parameters.
    /// </summary>
    /// <value>The total number of search results with given parameters.</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }

    /// <summary>
    /// Indicates whether the search fallback was used. If true, no items matching exact given phrase were found and related items are presented.
    /// </summary>
    /// <value>Indicates whether the search fallback was used. If true, no items matching exact given phrase were found and related items are presented.</value>
    [DataMember(Name="fallback", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fallback")]
    public bool? Fallback { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListingResponseSearchMeta {\n");
      sb.Append("  AvailableCount: ").Append(AvailableCount).Append("\n");
      sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
      sb.Append("  Fallback: ").Append(Fallback).Append("\n");
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
