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
  public class CheckoutFormPaymentReference {
    /// <summary>
    /// Payment id
    /// </summary>
    /// <value>Payment id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public CheckoutFormPaymentType Type { get; set; }

    /// <summary>
    /// Gets or Sets Provider
    /// </summary>
    [DataMember(Name="provider", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "provider")]
    public CheckoutFormPaymentProvider Provider { get; set; }

    /// <summary>
    /// Date when the event occurred
    /// </summary>
    /// <value>Date when the event occurred</value>
    [DataMember(Name="finishedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>
    /// Gets or Sets PaidAmount
    /// </summary>
    [DataMember(Name="paidAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "paidAmount")]
    public Price PaidAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutFormPaymentReference {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Provider: ").Append(Provider).Append("\n");
      sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
      sb.Append("  PaidAmount: ").Append(PaidAmount).Append("\n");
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
