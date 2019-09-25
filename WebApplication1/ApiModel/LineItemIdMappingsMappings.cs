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
  public class LineItemIdMappingsMappings {
    /// <summary>
    /// WebAPI deal id
    /// </summary>
    /// <value>WebAPI deal id</value>
    [DataMember(Name="dealId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dealId")]
    public string DealId { get; set; }

    /// <summary>
    /// Order API line item id
    /// </summary>
    /// <value>Order API line item id</value>
    [DataMember(Name="lineItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lineItemId")]
    public Guid? LineItemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class LineItemIdMappingsMappings {\n");
      sb.Append("  DealId: ").Append(DealId).Append("\n");
      sb.Append("  LineItemId: ").Append(LineItemId).Append("\n");
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
