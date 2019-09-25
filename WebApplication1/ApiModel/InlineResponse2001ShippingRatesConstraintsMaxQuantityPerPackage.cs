using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Rules for the quantity per parcel.
  /// </summary>
  [DataContract]
  public class InlineResponse2001ShippingRatesConstraintsMaxQuantityPerPackage {
    /// <summary>
    /// Upper limit for quantity per package.
    /// </summary>
    /// <value>Upper limit for quantity per package.</value>
    [DataMember(Name="max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max")]
    public int? Max { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse2001ShippingRatesConstraintsMaxQuantityPerPackage {\n");
      sb.Append("  Max: ").Append(Max).Append("\n");
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
