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
  public class UserRating {
    /// <summary>
    /// Gets or Sets Answer
    /// </summary>
    [DataMember(Name="answer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "answer")]
    public Answer Answer { get; set; }

    /// <summary>
    /// Gets or Sets Buyer
    /// </summary>
    [DataMember(Name="buyer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "buyer")]
    public User Buyer { get; set; }

    /// <summary>
    /// Buyer's text comment
    /// </summary>
    /// <value>Buyer's text comment</value>
    [DataMember(Name="comment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "comment")]
    public string Comment { get; set; }

    /// <summary>
    /// Creation datetime in ISO 8601 format
    /// </summary>
    /// <value>Creation datetime in ISO 8601 format</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// If true this rating was not included in calculating average user rates
    /// </summary>
    /// <value>If true this rating was not included in calculating average user rates</value>
    [DataMember(Name="excludedFromAverageRates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "excludedFromAverageRates")]
    public bool? ExcludedFromAverageRates { get; set; }

    /// <summary>
    /// Rating id
    /// </summary>
    /// <value>Rating id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    [DataMember(Name="order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "order")]
    public Order Order { get; set; }

    /// <summary>
    /// Gets or Sets Rates
    /// </summary>
    [DataMember(Name="rates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rates")]
    public Rates Rates { get; set; }

    /// <summary>
    /// Whether buyer recommends the order
    /// </summary>
    /// <value>Whether buyer recommends the order</value>
    [DataMember(Name="recommended", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "recommended")]
    public bool? Recommended { get; set; }

    /// <summary>
    /// Gets or Sets Removal
    /// </summary>
    [DataMember(Name="removal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "removal")]
    public Removal Removal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserRating {\n");
      sb.Append("  Answer: ").Append(Answer).Append("\n");
      sb.Append("  Buyer: ").Append(Buyer).Append("\n");
      sb.Append("  Comment: ").Append(Comment).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  ExcludedFromAverageRates: ").Append(ExcludedFromAverageRates).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Order: ").Append(Order).Append("\n");
      sb.Append("  Rates: ").Append(Rates).Append("\n");
      sb.Append("  Recommended: ").Append(Recommended).Append("\n");
      sb.Append("  Removal: ").Append(Removal).Append("\n");
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
