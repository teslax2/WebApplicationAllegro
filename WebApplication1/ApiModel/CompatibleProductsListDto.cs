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
  public class CompatibleProductsListDto {
    /// <summary>
    /// List of compatible products for given type and parameters.
    /// </summary>
    /// <value>List of compatible products for given type and parameters.</value>
    [DataMember(Name="compatibleProducts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compatibleProducts")]
    public List<CompatibleProductDto> CompatibleProducts { get; set; }

    /// <summary>
    /// Number of returned elements.
    /// </summary>
    /// <value>Number of returned elements.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Total number of available elements. Field is not present when `phrase` parameter is used.
    /// </summary>
    /// <value>Total number of available elements. Field is not present when `phrase` parameter is used.</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CompatibleProductsListDto {\n");
      sb.Append("  CompatibleProducts: ").Append(CompatibleProducts).Append("\n");
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
