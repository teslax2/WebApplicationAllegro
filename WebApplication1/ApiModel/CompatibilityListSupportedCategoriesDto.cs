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
  public class CompatibilityListSupportedCategoriesDto {
    /// <summary>
    /// List with information about categories where compatibility list is supported. <a href=\" https://developer.allegro.pl/compatibility_list/\" target=\"_blank\">Read more</a>.
    /// </summary>
    /// <value>List with information about categories where compatibility list is supported. <a href=\" https://developer.allegro.pl/compatibility_list/\" target=\"_blank\">Read more</a>.</value>
    [DataMember(Name="supportedCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportedCategories")]
    public List<CompatibilityListSupportedCategoriesDtoSupportedCategories> SupportedCategories { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CompatibilityListSupportedCategoriesDto {\n");
      sb.Append("  SupportedCategories: ").Append(SupportedCategories).Append("\n");
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
