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
  public class PaymentOperations {
    /// <summary>
    /// Collection of payment operations.
    /// </summary>
    /// <value>Collection of payment operations.</value>
    [DataMember(Name="paymentOperations", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paymentOperations")]
    public List<BaseOperation> _PaymentOperations { get; set; }

    /// <summary>
    /// Number of payment operations returned in search result for the given parameters.
    /// </summary>
    /// <value>Number of payment operations returned in search result for the given parameters.</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Total number of payment operations for the given parameters.
    /// </summary>
    /// <value>Total number of payment operations for the given parameters.</value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public int? TotalCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PaymentOperations {\n");
      sb.Append("  _PaymentOperations: ").Append(_PaymentOperations).Append("\n");
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
