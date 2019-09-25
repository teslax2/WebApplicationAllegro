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
  public class CheckoutFormInvoiceAddressCompany {
    /// <summary>
    /// Name of a company for which invoice should be issued
    /// </summary>
    /// <value>Name of a company for which invoice should be issued</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Tax id
    /// </summary>
    /// <value>Tax id</value>
    [DataMember(Name="taxId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxId")]
    public string TaxId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutFormInvoiceAddressCompany {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
