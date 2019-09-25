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
  public class ShippingRate {
    /// <summary>
    /// Gets or Sets DeliveryMethod
    /// </summary>
    [DataMember(Name="deliveryMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deliveryMethod")]
    public ShippingRateDeliveryMethod DeliveryMethod { get; set; }

    /// <summary>
    /// Maximum quantity per package for the given delivery method. Minimum value is 1.
    /// </summary>
    /// <value>Maximum quantity per package for the given delivery method. Minimum value is 1.</value>
    [DataMember(Name="maxQuantityPerPackage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxQuantityPerPackage")]
    public int? MaxQuantityPerPackage { get; set; }

    /// <summary>
    /// Gets or Sets FirstItemRate
    /// </summary>
    [DataMember(Name="firstItemRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstItemRate")]
    public ShippingRateFirstItemRate FirstItemRate { get; set; }

    /// <summary>
    /// Gets or Sets NextItemRate
    /// </summary>
    [DataMember(Name="nextItemRate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextItemRate")]
    public ShippingRateNextItemRate NextItemRate { get; set; }

    /// <summary>
    /// Gets or Sets ShippingTime
    /// </summary>
    [DataMember(Name="shippingTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "shippingTime")]
    public ShippingRateShippingTime ShippingTime { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ShippingRate {\n");
      sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
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
