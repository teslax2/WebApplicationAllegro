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
  public class SellerOfferEventsResponse {
    /// <summary>
    /// The list of events.
    /// </summary>
    /// <value>The list of events.</value>
    [DataMember(Name="offerEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerEvents")]
    public List<SellerOfferBaseEvent> OfferEvents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SellerOfferEventsResponse {\n");
      sb.Append("  OfferEvents: ").Append(OfferEvents).Append("\n");
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
