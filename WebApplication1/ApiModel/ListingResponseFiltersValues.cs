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
  public class ListingResponseFiltersValues {
    /// <summary>
    /// Name of the option; for NUMERIC parameters - word indicating start or end of range (i.e. *from*, *to*).
    /// </summary>
    /// <value>Name of the option; for NUMERIC parameters - word indicating start or end of range (i.e. *from*, *to*).</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Filter value. Should be used as query parameter value in the request. This can be:   - for MULTI and SINGLE parameters - a value identifier (e.g. KUJAWSKO_POMORSKIE option in location.province  filter),  - for other types - a value entered by user.
    /// </summary>
    /// <value>Filter value. Should be used as query parameter value in the request. This can be:   - for MULTI and SINGLE parameters - a value identifier (e.g. KUJAWSKO_POMORSKIE option in location.province  filter),  - for other types - a value entered by user.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Suffix used as a second part of query parameter name to be used in the request (the first part is the filter ID). Applicable for NUMERIC values only.
    /// </summary>
    /// <value>Suffix used as a second part of query parameter name to be used in the request (the first part is the filter ID). Applicable for NUMERIC values only.</value>
    [DataMember(Name="idSuffix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idSuffix")]
    public string IdSuffix { get; set; }

    /// <summary>
    /// Number of search results matching this filter value.
    /// </summary>
    /// <value>Number of search results matching this filter value.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Indicates whether this filter value was used in the current request.
    /// </summary>
    /// <value>Indicates whether this filter value was used in the current request.</value>
    [DataMember(Name="selected", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selected")]
    public bool? Selected { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListingResponseFiltersValues {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  IdSuffix: ").Append(IdSuffix).Append("\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  Selected: ").Append(Selected).Append("\n");
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
