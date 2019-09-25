using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// The category data.
  /// </summary>
  [DataContract]
  public class CategoryDto {
    /// <summary>
    /// The ID of the category. This can be either in UUID format or an integer format. You should be ready to accept any string value as the category ID.
    /// </summary>
    /// <value>The ID of the category. This can be either in UUID format or an integer format. You should be ready to accept any string value as the category ID.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Indicates whether the category is at the lowest level. Leaf categories do not have any children. Offers can be listed only in leaf categories.
    /// </summary>
    /// <value>Indicates whether the category is at the lowest level. Leaf categories do not have any children. Offers can be listed only in leaf categories.</value>
    [DataMember(Name="leaf", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "leaf")]
    public bool? Leaf { get; set; }

    /// <summary>
    /// Name of the category in Polish.
    /// </summary>
    /// <value>Name of the category in Polish.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public CategoryOptionsDto Options { get; set; }

    /// <summary>
    /// Gets or Sets Parent
    /// </summary>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public CategoryDtoParent Parent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CategoryDto {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Leaf: ").Append(Leaf).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
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
