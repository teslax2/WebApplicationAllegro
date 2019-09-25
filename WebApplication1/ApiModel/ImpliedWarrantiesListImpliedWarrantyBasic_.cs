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
  public class ImpliedWarrantiesListImpliedWarrantyBasic_ {
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name="count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "count")]
    public int? Count { get; set; }

    /// <summary>
    /// Gets or Sets ImpliedWarranties
    /// </summary>
    [DataMember(Name="impliedWarranties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "impliedWarranties")]
    public List<ImpliedWarrantyBasic> ImpliedWarranties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ImpliedWarrantiesListImpliedWarrantyBasic_ {\n");
      sb.Append("  Count: ").Append(Count).Append("\n");
      sb.Append("  ImpliedWarranties: ").Append(ImpliedWarranties).Append("\n");
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
