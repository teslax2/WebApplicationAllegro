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
  public class CheckoutFormInvoiceAddress {
    /// <summary>
    /// Street name
    /// </summary>
    /// <value>Street name</value>
    [DataMember(Name="street", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "street")]
    public string Street { get; set; }

    /// <summary>
    /// City name
    /// </summary>
    /// <value>City name</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Postal code
    /// </summary>
    /// <value>Postal code</value>
    [DataMember(Name="zipCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }

    /// <summary>
    /// Country code
    /// </summary>
    /// <value>Country code</value>
    [DataMember(Name="countryCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or Sets Company
    /// </summary>
    [DataMember(Name="company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company")]
    public CheckoutFormInvoiceAddressCompany Company { get; set; }

    /// <summary>
    /// Gets or Sets NaturalPerson
    /// </summary>
    [DataMember(Name="naturalPerson", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "naturalPerson")]
    public CheckoutFormInvoiceAddressNaturalPerson NaturalPerson { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutFormInvoiceAddress {\n");
      sb.Append("  Street: ").Append(Street).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
      sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
      sb.Append("  Company: ").Append(Company).Append("\n");
      sb.Append("  NaturalPerson: ").Append(NaturalPerson).Append("\n");
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
