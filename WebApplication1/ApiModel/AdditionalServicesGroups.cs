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
  public class AdditionalServicesGroups {
    /// <summary>
    /// Gets or Sets _AdditionalServicesGroups
    /// </summary>
    [DataMember(Name="additionalServicesGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalServicesGroups")]
    public List<AdditionalServicesGroupResponse> _AdditionalServicesGroups { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AdditionalServicesGroups {\n");
      sb.Append("  _AdditionalServicesGroups: ").Append(_AdditionalServicesGroups).Append("\n");
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
