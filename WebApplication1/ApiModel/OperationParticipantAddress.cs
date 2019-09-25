using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Address.
  /// </summary>
  [DataContract]
  public class OperationParticipantAddress {
    /// <summary>
    /// Street.
    /// </summary>
    /// <value>Street.</value>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }

    /// <summary>
    /// City.
    /// </summary>
    /// <value>City.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Postal code.
    /// </summary>
    /// <value>Postal code.</value>
    [DataMember(Name="postCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "postCode")]
    public string PostCode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OperationParticipantAddress {\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  PostCode: ").Append(PostCode).Append("\n");
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
