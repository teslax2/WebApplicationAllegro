using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Information about the seller.
  /// </summary>
  [DataContract]
  public class OfferSeller {
    /// <summary>
    /// The seller ID.
    /// </summary>
    /// <value>The seller ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Indicates whether the seller represents a registered business.
    /// </summary>
    /// <value>Indicates whether the seller represents a registered business.</value>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public bool? Company { get; set; }

    /// <summary>
    /// Indicates whether the seller has the \"Super Sprzedawca\" status.
    /// </summary>
    /// <value>Indicates whether the seller has the \"Super Sprzedawca\" status.</value>
    [DataMember(Name="superSeller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "superSeller")]
    public bool? SuperSeller { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferSeller {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  SuperSeller: ").Append(SuperSeller).Append("\n");
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
