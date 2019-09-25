using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Information about categories.
  /// </summary>
  [DataContract]
  public class ListingResponseCategories {
    /// <summary>
    /// Categories with counters, which can be used to refine search results.
    /// </summary>
    /// <value>Categories with counters, which can be used to refine search results.</value>
    [DataMember(Name="subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subcategories")]
    public List<ListingCategoryWithCount> Subcategories { get; set; }

    /// <summary>
    /// Categories path to the current listing category (breadcrumbs).
    /// </summary>
    /// <value>Categories path to the current listing category (breadcrumbs).</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public List<ListingCategory> Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListingResponseCategories {\n");
      sb.Append("  Subcategories: ").Append(Subcategories).Append("\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
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
