using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Single offer data
  /// </summary>
  [DataContract]
  public class Offer {
    /// <summary>
    /// Gets or Sets AdditionalServices
    /// </summary>
    [DataMember(Name="additionalServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "additionalServices")]
    public JustId AdditionalServices { get; set; }

    /// <summary>
    /// Gets or Sets AfterSalesServices
    /// </summary>
    [DataMember(Name="afterSalesServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "afterSalesServices")]
    public AfterSalesServices AfterSalesServices { get; set; }

    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public Category Category { get; set; }

    /// <summary>
    /// Gets or Sets CompatibilityList
    /// </summary>
    [DataMember(Name="compatibilityList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "compatibilityList")]
    public CompatibilityList CompatibilityList { get; set; }

    /// <summary>
    /// Gets or Sets Contact
    /// </summary>
    [DataMember(Name="contact", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contact")]
    public JustId Contact { get; set; }

    /// <summary>
    /// Creation date: Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ. Cannot be modified
    /// </summary>
    /// <value>Creation date: Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ. Cannot be modified</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Delivery
    /// </summary>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delivery")]
    public Delivery Delivery { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public StandardizedDescription Description { get; set; }

    /// <summary>
    /// Gets or Sets Ean
    /// </summary>
    [DataMember(Name="ean", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ean")]
    public string Ean { get; set; }

    /// <summary>
    /// Gets or Sets External
    /// </summary>
    [DataMember(Name="external", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "external")]
    public ExternalId External { get; set; }

    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<ImageUrl> Images { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public Location Location { get; set; }

    /// <summary>
    /// Name of the offer. Words used in the name field cannot be longer than 30 characters.
    /// </summary>
    /// <value>Name of the offer. Words used in the name field cannot be longer than 30 characters.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Parameters
    /// </summary>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<Parameter> Parameters { get; set; }

    /// <summary>
    /// Gets or Sets Payments
    /// </summary>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public Payments Payments { get; set; }

    /// <summary>
    /// Gets or Sets Product
    /// </summary>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public JustId Product { get; set; }

    /// <summary>
    /// Gets or Sets Promotion
    /// </summary>
    [DataMember(Name="promotion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "promotion")]
    public Promotion Promotion { get; set; }

    /// <summary>
    /// Gets or Sets Publication
    /// </summary>
    [DataMember(Name="publication", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publication")]
    public Publication Publication { get; set; }

    /// <summary>
    /// Gets or Sets SellingMode
    /// </summary>
    [DataMember(Name="sellingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sellingMode")]
    public SellingMode SellingMode { get; set; }

    /// <summary>
    /// Gets or Sets SizeTable
    /// </summary>
    [DataMember(Name="sizeTable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizeTable")]
    public JustId SizeTable { get; set; }

    /// <summary>
    /// Gets or Sets Stock
    /// </summary>
    [DataMember(Name="stock", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stock")]
    public Stock Stock { get; set; }

    /// <summary>
    /// Last update date: Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ. Cannot be modified
    /// </summary>
    /// <value>Last update date: Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ. Cannot be modified</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Gets or Sets Validation
    /// </summary>
    [DataMember(Name="validation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "validation")]
    public Validation Validation { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Offer {\n");
      sb.Append("  AdditionalServices: ").Append(AdditionalServices).Append("\n");
      sb.Append("  AfterSalesServices: ").Append(AfterSalesServices).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  CompatibilityList: ").Append(CompatibilityList).Append("\n");
      sb.Append("  Contact: ").Append(Contact).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Ean: ").Append(Ean).Append("\n");
      sb.Append("  External: ").Append(External).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  Promotion: ").Append(Promotion).Append("\n");
      sb.Append("  Publication: ").Append(Publication).Append("\n");
      sb.Append("  SellingMode: ").Append(SellingMode).Append("\n");
      sb.Append("  SizeTable: ").Append(SizeTable).Append("\n");
      sb.Append("  Stock: ").Append(Stock).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Validation: ").Append(Validation).Append("\n");
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
