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
  public class GetSaleProductsResponse {
    /// <summary>
    /// Gets or Sets Products
    /// </summary>
    [DataMember(Name="products", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "products")]
    public List<SaleProductResponseDto> Products { get; set; }

    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categories")]
    public List<SaleProductResponseCategoriesDto> Categories { get; set; }

    /// <summary>
    /// Gets or Sets Filters
    /// </summary>
    [DataMember(Name="filters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filters")]
    public List<ListingResponseFilters> Filters { get; set; }

    /// <summary>
    /// Gets or Sets NextPage
    /// </summary>
    [DataMember(Name="nextPage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextPage")]
    public GetSaleProductsResponseNextPage NextPage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetSaleProductsResponse {\n");
      sb.Append("  Products: ").Append(Products).Append("\n");
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      sb.Append("  Filters: ").Append(Filters).Append("\n");
      sb.Append("  NextPage: ").Append(NextPage).Append("\n");
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
