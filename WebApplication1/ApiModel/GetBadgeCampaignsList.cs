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
  public class GetBadgeCampaignsList {
    /// <summary>
    /// List of badge campaigns.
    /// </summary>
    /// <value>List of badge campaigns.</value>
    [DataMember(Name="badgeCampaigns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "badgeCampaigns")]
    public List<BadgeCampaign> BadgeCampaigns { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetBadgeCampaignsList {\n");
      sb.Append("  BadgeCampaigns: ").Append(BadgeCampaigns).Append("\n");
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
