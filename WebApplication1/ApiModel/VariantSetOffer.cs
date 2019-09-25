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
  public class VariantSetOffer {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Label that allows to group variants via image. All variants having the same image should have identical identifier in this field.
    /// </summary>
    /// <value>Label that allows to group variants via image. All variants having the same image should have identical identifier in this field.</value>
    [DataMember(Name="colorPattern", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colorPattern")]
    public string ColorPattern { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VariantSetOffer {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ColorPattern: ").Append(ColorPattern).Append("\n");
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
