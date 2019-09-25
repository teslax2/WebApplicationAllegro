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
  public class SellerRebateOfferCriterionOffers {
    /// <summary>
    /// Offer id
    /// </summary>
    /// <value>Offer id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// that many pieces of your offer will be part of the bundle, valid only for bundle `ORDER_FIXED_DISCOUNT` promotions
    /// </summary>
    /// <value>that many pieces of your offer will be part of the bundle, valid only for bundle `ORDER_FIXED_DISCOUNT` promotions</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// offers with this flag set to true will have a section that allows the users to purchase your bundle, valid only for bundle `ORDER_FIXED_DISCOUNT` promotions
    /// </summary>
    /// <value>offers with this flag set to true will have a section that allows the users to purchase your bundle, valid only for bundle `ORDER_FIXED_DISCOUNT` promotions</value>
    [DataMember(Name="promotionEntryPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promotionEntryPoint")]
    public bool? PromotionEntryPoint { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SellerRebateOfferCriterionOffers {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  PromotionEntryPoint: ").Append(PromotionEntryPoint).Append("\n");
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
