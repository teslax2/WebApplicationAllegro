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
  public class SurchargeOperation : BaseOperation {
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Payment
    /// </summary>
    [DataMember(Name="payment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payment")]
    public OperationPayment Payment { get; set; }

    /// <summary>
    /// Gets or Sets Surcharge
    /// </summary>
    [DataMember(Name="surcharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surcharge")]
    public Surcharge Surcharge { get; set; }

    /// <summary>
    /// Gets or Sets Participant
    /// </summary>
    [DataMember(Name="participant", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "participant")]
    public BuyerParticipant Participant { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SurchargeOperation {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Payment: ").Append(Payment).Append("\n");
      sb.Append("  Surcharge: ").Append(Surcharge).Append("\n");
      sb.Append("  Participant: ").Append(Participant).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
