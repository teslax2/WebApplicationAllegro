using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Summary of user eligibility for participation in the campaign.
  /// </summary>
  [DataContract]
  public class UserCampaignEligibility {
    /// <summary>
    /// Information whether user is eligible to participate in this campaign.
    /// </summary>
    /// <value>Information whether user is eligible to participate in this campaign.</value>
    [DataMember(Name="eligible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eligible")]
    public bool? Eligible { get; set; }

    /// <summary>
    /// Information why user is not able to participate in the campaign.
    /// </summary>
    /// <value>Information why user is not able to participate in the campaign.</value>
    [DataMember(Name="refusalReasons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "refusalReasons")]
    public List<CampaignRefusalReason> RefusalReasons { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserCampaignEligibility {\n");
      sb.Append("  Eligible: ").Append(Eligible).Append("\n");
      sb.Append("  RefusalReasons: ").Append(RefusalReasons).Append("\n");
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
