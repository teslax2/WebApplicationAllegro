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
  public class CheckoutForm {
    /// <summary>
    /// Checkout form id
    /// </summary>
    /// <value>Checkout form id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Message from buyer to seller
    /// </summary>
    /// <value>Message from buyer to seller</value>
    [DataMember(Name="messageToSeller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "messageToSeller")]
    public string MessageToSeller { get; set; }

    /// <summary>
    /// Gets or Sets Buyer
    /// </summary>
    [DataMember(Name="buyer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyer")]
    public CheckoutFormBuyerReference Buyer { get; set; }

    /// <summary>
    /// Gets or Sets Payment
    /// </summary>
    [DataMember(Name="payment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment")]
    public CheckoutFormPaymentReference Payment { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public CheckoutFormStatus Status { get; set; }

    /// <summary>
    /// Gets or Sets Delivery
    /// </summary>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery")]
    public CheckoutFormDeliveryReference Delivery { get; set; }

    /// <summary>
    /// Gets or Sets Invoice
    /// </summary>
    [DataMember(Name="invoice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "invoice")]
    public CheckoutFormInvoiceInfo Invoice { get; set; }

    /// <summary>
    /// Gets or Sets LineItems
    /// </summary>
    [DataMember(Name="lineItems", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineItems")]
    public List<CheckoutFormLineItem> LineItems { get; set; }

    /// <summary>
    /// Gets or Sets Surcharges
    /// </summary>
    [DataMember(Name="surcharges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surcharges")]
    public List<CheckoutFormPaymentReference> Surcharges { get; set; }

    /// <summary>
    /// Gets or Sets Discounts
    /// </summary>
    [DataMember(Name="discounts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discounts")]
    public List<CheckoutFormDiscount> Discounts { get; set; }

    /// <summary>
    /// Gets or Sets Summary
    /// </summary>
    [DataMember(Name="summary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "summary")]
    public CheckoutFormSummary Summary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutForm {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  MessageToSeller: ").Append(MessageToSeller).Append("\n");
      sb.Append("  Buyer: ").Append(Buyer).Append("\n");
      sb.Append("  Payment: ").Append(Payment).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
      sb.Append("  Invoice: ").Append(Invoice).Append("\n");
      sb.Append("  LineItems: ").Append(LineItems).Append("\n");
      sb.Append("  Surcharges: ").Append(Surcharges).Append("\n");
      sb.Append("  Discounts: ").Append(Discounts).Append("\n");
      sb.Append("  Summary: ").Append(Summary).Append("\n");
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
