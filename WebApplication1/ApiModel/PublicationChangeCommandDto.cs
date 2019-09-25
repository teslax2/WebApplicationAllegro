using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Publication modification command payload
  /// </summary>
  [DataContract]
  public class PublicationChangeCommandDto {
    /// <summary>
    /// List of offer criteria
    /// </summary>
    /// <value>List of offer criteria</value>
    [DataMember(Name="offerCriteria", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerCriteria")]
    public List<OfferCriterium> OfferCriteria { get; set; }

    /// <summary>
    /// Gets or Sets Publication
    /// </summary>
    [DataMember(Name="publication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publication")]
    public PublicationModification Publication { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PublicationChangeCommandDto {\n");
      sb.Append("  OfferCriteria: ").Append(OfferCriteria).Append("\n");
      sb.Append("  Publication: ").Append(Publication).Append("\n");
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
