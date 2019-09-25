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
  public class CheckoutForms {
    /// <summary>
    /// Gets or Sets _CheckoutForms
    /// </summary>
    [DataMember(Name="checkoutForms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkoutForms")]
    public List<CheckoutForm> _CheckoutForms { get; set; }

    /// <summary>
    /// number of returned objects
    /// </summary>
    /// <value>number of returned objects</value>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public decimal? Count { get; set; }

    /// <summary>
    /// Number of all objects of requested status(es) available (regardless of the provided limit and offset) 
    /// </summary>
    /// <value>Number of all objects of requested status(es) available (regardless of the provided limit and offset) </value>
    [DataMember(Name="totalCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalCount")]
    public decimal? TotalCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutForms {\n");
      sb.Append("  _CheckoutForms: ").Append(_CheckoutForms).Append("\n");
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
