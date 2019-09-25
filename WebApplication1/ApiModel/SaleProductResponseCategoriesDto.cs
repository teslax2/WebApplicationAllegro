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
  public class SaleProductResponseCategoriesDto {
    /// <summary>
    /// A list of categories that contain results for given search parameters.
    /// </summary>
    /// <value>A list of categories that contain results for given search parameters.</value>
    [DataMember(Name="subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subcategories")]
    public List<ProductsCategorySubcategories> Subcategories { get; set; }

    /// <summary>
    /// The path of current category used as categrory filter in search.
    /// </summary>
    /// <value>The path of current category used as categrory filter in search.</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public List<ProductsCategoryPath> Path { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaleProductResponseCategoriesDto {\n");
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
