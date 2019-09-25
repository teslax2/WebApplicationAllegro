using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Order event data
  /// </summary>
  [DataContract]
  public class OrderEventData {
    /// <summary>
    /// Gets or Sets Seller
    /// </summary>
    [DataMember(Name="seller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seller")]
    public SellerReference Seller { get; set; }

    /// <summary>
    /// Gets or Sets Buyer
    /// </summary>
    [DataMember(Name="buyer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyer")]
    public BuyerReference Buyer { get; set; }

    /// <summary>
    /// Gets or Sets LineItems
    /// </summary>
    [DataMember(Name="lineItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineItems")]
    public List<OrderLineItem> LineItems { get; set; }

    /// <summary>
    /// Gets or Sets CheckoutForm
    /// </summary>
    [DataMember(Name="checkoutForm", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkoutForm")]
    public CheckoutFormReference CheckoutForm { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OrderEventData {\n");
      sb.Append("  Seller: ").Append(Seller).Append("\n");
      sb.Append("  Buyer: ").Append(Buyer).Append("\n");
      sb.Append("  LineItems: ").Append(LineItems).Append("\n");
      sb.Append("  CheckoutForm: ").Append(CheckoutForm).Append("\n");
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
