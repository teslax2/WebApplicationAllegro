using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Contains fields to change
  /// </summary>
  [DataContract]
  public class Modification {
    /// <summary>
    /// Gets or Sets AdditionalServicesGroup
    /// </summary>
    [DataMember(Name="additionalServicesGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalServicesGroup")]
    public AdditionalServicesGroup AdditionalServicesGroup { get; set; }

    /// <summary>
    /// Gets or Sets Delivery
    /// </summary>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery")]
    public ModificationDelivery Delivery { get; set; }

    /// <summary>
    /// Gets or Sets Payments
    /// </summary>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public ModificationPayments Payments { get; set; }

    /// <summary>
    /// Gets or Sets Promotion
    /// </summary>
    [DataMember(Name="promotion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promotion")]
    public ModificationPromotion Promotion { get; set; }

    /// <summary>
    /// Gets or Sets SizeTable
    /// </summary>
    [DataMember(Name="sizeTable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizeTable")]
    public ModificationSizeTable SizeTable { get; set; }

    /// <summary>
    /// Gets or Sets Publication
    /// </summary>
    [DataMember(Name="publication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publication")]
    public ModificationPublication Publication { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Modification {\n");
      sb.Append("  AdditionalServicesGroup: ").Append(AdditionalServicesGroup).Append("\n");
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
      sb.Append("  Promotion: ").Append(Promotion).Append("\n");
      sb.Append("  SizeTable: ").Append(SizeTable).Append("\n");
      sb.Append("  Publication: ").Append(Publication).Append("\n");
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
