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
  public class PromotionCampaignRequestDto {
    /// <summary>
    /// Gets or Sets Promotion
    /// </summary>
    [DataMember(Name="promotion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promotion")]
    public PromotionRequestDto Promotion { get; set; }

    /// <summary>
    /// Gets or Sets Campaign
    /// </summary>
    [DataMember(Name="campaign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "campaign")]
    public CampaignRequestDto Campaign { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PromotionCampaignRequestDto {\n");
      sb.Append("  Promotion: ").Append(Promotion).Append("\n");
      sb.Append("  Campaign: ").Append(Campaign).Append("\n");
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
