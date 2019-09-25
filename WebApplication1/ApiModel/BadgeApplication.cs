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
  public class BadgeApplication {
    /// <summary>
    /// Badge application ID.
    /// </summary>
    /// <value>Badge application ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Provided in [ISO 8601 format](link: https://en.wikipedia.org/wiki/ISO_8601).
    /// </summary>
    /// <value>Provided in [ISO 8601 format](link: https://en.wikipedia.org/wiki/ISO_8601).</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Provided in [ISO 8601 format](link: https://en.wikipedia.org/wiki/ISO_8601).
    /// </summary>
    /// <value>Provided in [ISO 8601 format](link: https://en.wikipedia.org/wiki/ISO_8601).</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public string UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Campaign
    /// </summary>
    [DataMember(Name="campaign", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "campaign")]
    public BadgeApplicationCampaign Campaign { get; set; }

    /// <summary>
    /// Gets or Sets Offer
    /// </summary>
    [DataMember(Name="offer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer")]
    public BadgeApplicationOffer Offer { get; set; }

    /// <summary>
    /// Gets or Sets Prices
    /// </summary>
    [DataMember(Name="prices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prices")]
    public BadgeApplicationPrices Prices { get; set; }

    /// <summary>
    /// Gets or Sets Process
    /// </summary>
    [DataMember(Name="process", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "process")]
    public BadgeApplicationProcess Process { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BadgeApplication {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Campaign: ").Append(Campaign).Append("\n");
      sb.Append("  Offer: ").Append(Offer).Append("\n");
      sb.Append("  Prices: ").Append(Prices).Append("\n");
      sb.Append("  Process: ").Append(Process).Append("\n");
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
