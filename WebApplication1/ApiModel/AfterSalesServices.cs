using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The definitions of the different after sales services assigned to the offer.
  /// </summary>
  [DataContract]
  public class AfterSalesServices {
    /// <summary>
    /// Gets or Sets ImpliedWarranty
    /// </summary>
    [DataMember(Name="impliedWarranty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "impliedWarranty")]
    public ImpliedWarranty ImpliedWarranty { get; set; }

    /// <summary>
    /// Gets or Sets ReturnPolicy
    /// </summary>
    [DataMember(Name="returnPolicy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "returnPolicy")]
    public ReturnPolicy ReturnPolicy { get; set; }

    /// <summary>
    /// Gets or Sets Warranty
    /// </summary>
    [DataMember(Name="warranty", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "warranty")]
    public Warranty Warranty { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AfterSalesServices {\n");
      sb.Append("  ImpliedWarranty: ").Append(ImpliedWarranty).Append("\n");
      sb.Append("  ReturnPolicy: ").Append(ReturnPolicy).Append("\n");
      sb.Append("  Warranty: ").Append(Warranty).Append("\n");
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
