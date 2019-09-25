using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Modification command payload
  /// </summary>
  [DataContract]
  public class OfferChangeCommand {
    /// <summary>
    /// Gets or Sets Modification
    /// </summary>
    [DataMember(Name="modification", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modification")]
    public Modification Modification { get; set; }

    /// <summary>
    /// List of offer criteria
    /// </summary>
    /// <value>List of offer criteria</value>
    [DataMember(Name="offerCriteria", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerCriteria")]
    public List<OfferCriterium> OfferCriteria { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferChangeCommand {\n");
      sb.Append("  Modification: ").Append(Modification).Append("\n");
      sb.Append("  OfferCriteria: ").Append(OfferCriteria).Append("\n");
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
