using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Describes what will cause the rebate.
  /// </summary>
  [DataContract]
  public class MultiPackBenefitSpecificationTrigger {
    /// <summary>
    /// For every pack of this quantity new rebate will be given.
    /// </summary>
    /// <value>For every pack of this quantity new rebate will be given.</value>
    [DataMember(Name="forEachQuantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "forEachQuantity")]
    public decimal? ForEachQuantity { get; set; }

    /// <summary>
    /// Describes how many offers in pack should be discounted by discount percentage.
    /// </summary>
    /// <value>Describes how many offers in pack should be discounted by discount percentage.</value>
    [DataMember(Name="discountedNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountedNumber")]
    public decimal? DiscountedNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MultiPackBenefitSpecificationTrigger {\n");
      sb.Append("  ForEachQuantity: ").Append(ForEachQuantity).Append("\n");
      sb.Append("  DiscountedNumber: ").Append(DiscountedNumber).Append("\n");
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
