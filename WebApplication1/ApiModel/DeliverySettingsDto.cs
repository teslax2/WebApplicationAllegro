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
  public class DeliverySettingsDto {
    /// <summary>
    /// Gets or Sets FreeDelivery
    /// </summary>
    [DataMember(Name="freeDelivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freeDelivery")]
    public DeliverySettingsDtoFreeDelivery FreeDelivery { get; set; }

    /// <summary>
    /// Gets or Sets JoinPolicy
    /// </summary>
    [DataMember(Name="joinPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "joinPolicy")]
    public DeliverySettingsDtoJoinPolicy JoinPolicy { get; set; }

    /// <summary>
    /// Gets or Sets CustomCost
    /// </summary>
    [DataMember(Name="customCost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customCost")]
    public DeliverySettingsDtoCustomCost CustomCost { get; set; }

    /// <summary>
    /// Date and time of the last modification of the set in UTC ISO 8601 format. When updating (Put) settings the field is ignored.
    /// </summary>
    /// <value>Date and time of the last modification of the set in UTC ISO 8601 format. When updating (Put) settings the field is ignored.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public string UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DeliverySettingsDto {\n");
      sb.Append("  FreeDelivery: ").Append(FreeDelivery).Append("\n");
      sb.Append("  JoinPolicy: ").Append(JoinPolicy).Append("\n");
      sb.Append("  CustomCost: ").Append(CustomCost).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
