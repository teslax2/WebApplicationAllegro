using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The lists of search results.
  /// </summary>
  [DataContract]
  public class ListingResponseOffers {
    /// <summary>
    /// List of promoted offers.
    /// </summary>
    /// <value>List of promoted offers.</value>
    [DataMember(Name="promoted", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promoted")]
    public List<ListingOffer> Promoted { get; set; }

    /// <summary>
    /// List of regular (non-promoted) offers.
    /// </summary>
    /// <value>List of regular (non-promoted) offers.</value>
    [DataMember(Name="regular", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "regular")]
    public List<ListingOffer> Regular { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ListingResponseOffers {\n");
      sb.Append("  Promoted: ").Append(Promoted).Append("\n");
      sb.Append("  Regular: ").Append(Regular).Append("\n");
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
