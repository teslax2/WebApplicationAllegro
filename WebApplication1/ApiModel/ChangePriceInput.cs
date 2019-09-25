using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The input of the command, i.e. the new Buy Now price for the offer.
  /// </summary>
  [DataContract]
  public class ChangePriceInput {
    /// <summary>
    /// Gets or Sets BuyNowPrice
    /// </summary>
    [DataMember(Name="buyNowPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyNowPrice")]
    public Price BuyNowPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChangePriceInput {\n");
      sb.Append("  BuyNowPrice: ").Append(BuyNowPrice).Append("\n");
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
