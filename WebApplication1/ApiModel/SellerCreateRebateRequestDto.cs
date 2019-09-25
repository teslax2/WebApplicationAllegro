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
  public class SellerCreateRebateRequestDto {
    /// <summary>
    /// What kind of rebate will be given
    /// </summary>
    /// <value>What kind of rebate will be given</value>
    [DataMember(Name="benefits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "benefits")]
    public List<Benefit> Benefits { get; set; }

    /// <summary>
    /// What offers will be included
    /// </summary>
    /// <value>What offers will be included</value>
    [DataMember(Name="offerCriteria", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerCriteria")]
    public List<SellerRebateOfferCriterion> OfferCriteria { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SellerCreateRebateRequestDto {\n");
      sb.Append("  Benefits: ").Append(Benefits).Append("\n");
      sb.Append("  OfferCriteria: ").Append(OfferCriteria).Append("\n");
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
