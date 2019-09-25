using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The bid request.
  /// </summary>
  [DataContract]
  public class BidRequest {
    /// <summary>
    /// Gets or Sets MaxAmount
    /// </summary>
    [DataMember(Name="maxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxAmount")]
    public MaxPrice MaxAmount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BidRequest {\n");
      sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
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
