using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Rules for the shipping time.
  /// </summary>
  [DataContract]
  public class InlineResponse2001ShippingRatesConstraintsShippingTime {
    /// <summary>
    /// Gets or Sets Default
    /// </summary>
    [DataMember(Name="default", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "default")]
    public InlineResponse2001ShippingRatesConstraintsShippingTimeDefault Default { get; set; }

    /// <summary>
    /// Indicates if custom shipping time can be set when adding or modifying shipping rates.
    /// </summary>
    /// <value>Indicates if custom shipping time can be set when adding or modifying shipping rates.</value>
    [DataMember(Name="customizable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customizable")]
    public bool? Customizable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class InlineResponse2001ShippingRatesConstraintsShippingTime {\n");
      sb.Append("  Default: ").Append(Default).Append("\n");
      sb.Append("  Customizable: ").Append(Customizable).Append("\n");
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
