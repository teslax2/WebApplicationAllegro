using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Rules for the shipping cost of another item in the parcel.
  /// </summary>
  [DataContract]
  public class InlineResponse2001ShippingRatesConstraintsNextItemRate {
    /// <summary>
    /// Lower limit for the rate.
    /// </summary>
    /// <value>Lower limit for the rate.</value>
    [DataMember(Name="min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "min")]
    public double? Min { get; set; }

    /// <summary>
    /// Upper limit for the rate.
    /// </summary>
    /// <value>Upper limit for the rate.</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max")]
    public double? Max { get; set; }

    /// <summary>
    /// ISO 4217 currency code.
    /// </summary>
    /// <value>ISO 4217 currency code.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse2001ShippingRatesConstraintsNextItemRate {\n");
      sb.Append("  Min: ").Append(Min).Append("\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
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
