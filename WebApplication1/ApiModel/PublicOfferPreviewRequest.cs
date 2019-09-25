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
  public class PublicOfferPreviewRequest {
    /// <summary>
    /// Gets or Sets Offer
    /// </summary>
    [DataMember(Name="offer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer")]
    public Offer Offer { get; set; }

    /// <summary>
    /// Gets or Sets ClassifiedsPackages
    /// </summary>
    [DataMember(Name="classifiedsPackages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classifiedsPackages")]
    public ClassifiedsPackages ClassifiedsPackages { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PublicOfferPreviewRequest {\n");
      sb.Append("  Offer: ").Append(Offer).Append("\n");
      sb.Append("  ClassifiedsPackages: ").Append(ClassifiedsPackages).Append("\n");
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
