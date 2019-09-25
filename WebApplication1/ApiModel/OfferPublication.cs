using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// This section is available only for offers with a defined end of publication.
  /// </summary>
  [DataContract]
  public class OfferPublication {
    /// <summary>
    /// Publication ending date and time in UTC.
    /// </summary>
    /// <value>Publication ending date and time in UTC.</value>
    [DataMember(Name="endingAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endingAt")]
    public string EndingAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferPublication {\n");
      sb.Append("  EndingAt: ").Append(EndingAt).Append("\n");
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
