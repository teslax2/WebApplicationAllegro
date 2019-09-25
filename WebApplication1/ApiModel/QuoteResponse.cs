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
  public class QuoteResponse {
    /// <summary>
    /// Quote fee name.
    /// </summary>
    /// <value>Quote fee name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Fee
    /// </summary>
    [DataMember(Name="fee", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fee")]
    public Price Fee { get; set; }

    /// <summary>
    /// Duration in ISO 8601 format.
    /// </summary>
    /// <value>Duration in ISO 8601 format.</value>
    [DataMember(Name="cycleDuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cycleDuration")]
    public string CycleDuration { get; set; }

    /// <summary>
    /// Gets or Sets ClassifiedsPackage
    /// </summary>
    [DataMember(Name="classifiedsPackage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classifiedsPackage")]
    public ClassifiedPackage ClassifiedsPackage { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class QuoteResponse {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Fee: ").Append(Fee).Append("\n");
      sb.Append("  CycleDuration: ").Append(CycleDuration).Append("\n");
      sb.Append("  ClassifiedsPackage: ").Append(ClassifiedsPackage).Append("\n");
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
