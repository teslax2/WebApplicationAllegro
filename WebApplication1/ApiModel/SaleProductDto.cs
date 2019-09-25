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
  public class SaleProductDto {
    /// <summary>
    /// Product id.
    /// </summary>
    /// <value>Product id.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Product name.
    /// </summary>
    /// <value>Product name.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public Category Category { get; set; }

    /// <summary>
    /// A list of codes that identify this product. Currently this can include EAN, ISBN, and UPC identifier types.
    /// </summary>
    /// <value>A list of codes that identify this product. Currently this can include EAN, ISBN, and UPC identifier types.</value>
    [DataMember(Name="eans", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "eans")]
    public List<string> Eans { get; set; }

    /// <summary>
    /// List of product images.
    /// </summary>
    /// <value>List of product images.</value>
    [DataMember(Name="images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "images")]
    public List<ImageUrl> Images { get; set; }

    /// <summary>
    /// List of product parameters.
    /// </summary>
    /// <value>List of product parameters.</value>
    [DataMember(Name="parameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameters")]
    public List<ProductParameter> Parameters { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public StandardizedDescription Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SaleProductDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Eans: ").Append(Eans).Append("\n");
      sb.Append("  Images: ").Append(Images).Append("\n");
      sb.Append("  Parameters: ").Append(Parameters).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
