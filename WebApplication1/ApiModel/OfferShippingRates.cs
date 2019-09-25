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
  public class OfferShippingRates {
    /// <summary>
    /// If empty there is the shipping rates set attached to offer. You should use the GET /sale/offers/{offerId} resource to retrieve the shipping rates set ID.
    /// </summary>
    /// <value>If empty there is the shipping rates set attached to offer. You should use the GET /sale/offers/{offerId} resource to retrieve the shipping rates set ID.</value>
    [DataMember(Name="rates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rates")]
    public List<ShippingRate> Rates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferShippingRates {\n");
      sb.Append("  Rates: ").Append(Rates).Append("\n");
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
