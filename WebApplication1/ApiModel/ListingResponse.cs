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
  public class ListingResponse {
    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public ListingResponseOffers Items { get; set; }

    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public ListingResponseCategories Categories { get; set; }

    /// <summary>
    /// An array of filters with counters available for given search. This can be used to refine the search results.
    /// </summary>
    /// <value>An array of filters with counters available for given search. This can be used to refine the search results.</value>
    [DataMember(Name="filters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filters")]
    public List<ListingResponseFilters> Filters { get; set; }

    /// <summary>
    /// Gets or Sets SearchMeta
    /// </summary>
    [DataMember(Name="searchMeta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchMeta")]
    public ListingResponseSearchMeta SearchMeta { get; set; }

    /// <summary>
    /// Available sorting options.
    /// </summary>
    /// <value>Available sorting options.</value>
    [DataMember(Name="sort", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort")]
    public List<ListingResponseSort> Sort { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListingResponse {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  Filters: ").Append(Filters).Append("\n");
      sb.Append("  SearchMeta: ").Append(SearchMeta).Append("\n");
      sb.Append("  Sort: ").Append(Sort).Append("\n");
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
