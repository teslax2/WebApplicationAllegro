using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Rules for the delivery method, i.e. price, quantity, shipping time, etc.
  /// </summary>
  [DataContract]
  public class InlineResponse2001ShippingRatesConstraints {
    /// <summary>
    /// Indicates whether delivery method can be used when adding or modifying shipping rates.
    /// </summary>
    /// <value>Indicates whether delivery method can be used when adding or modifying shipping rates.</value>
    [DataMember(Name="allowed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowed")]
    public bool? Allowed { get; set; }

    /// <summary>
    /// Gets or Sets MaxQuantityPerPackage
    /// </summary>
    [DataMember(Name="maxQuantityPerPackage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxQuantityPerPackage")]
    public InlineResponse2001ShippingRatesConstraintsMaxQuantityPerPackage MaxQuantityPerPackage { get; set; }

    /// <summary>
    /// Gets or Sets FirstItemRate
    /// </summary>
    [DataMember(Name="firstItemRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstItemRate")]
    public InlineResponse2001ShippingRatesConstraintsFirstItemRate FirstItemRate { get; set; }

    /// <summary>
    /// Gets or Sets NextItemRate
    /// </summary>
    [DataMember(Name="nextItemRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextItemRate")]
    public InlineResponse2001ShippingRatesConstraintsNextItemRate NextItemRate { get; set; }

    /// <summary>
    /// Gets or Sets ShippingTime
    /// </summary>
    [DataMember(Name="shippingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingTime")]
    public InlineResponse2001ShippingRatesConstraintsShippingTime ShippingTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse2001ShippingRatesConstraints {\n");
      sb.Append("  Allowed: ").Append(Allowed).Append("\n");
      sb.Append("  MaxQuantityPerPackage: ").Append(MaxQuantityPerPackage).Append("\n");
      sb.Append("  FirstItemRate: ").Append(FirstItemRate).Append("\n");
      sb.Append("  NextItemRate: ").Append(NextItemRate).Append("\n");
      sb.Append("  ShippingTime: ").Append(ShippingTime).Append("\n");
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
