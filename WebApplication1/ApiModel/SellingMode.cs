using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Information on the offer&#x27;s selling mode.
  /// </summary>
  [DataContract]
  public class SellingMode {
    /// <summary>
    /// Gets or Sets Format
    /// </summary>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public SellingModeFormat Format { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public BuyNowPrice Price { get; set; }

    /// <summary>
    /// Gets or Sets MinimalPrice
    /// </summary>
    [DataMember(Name="minimalPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimalPrice")]
    public MinimalPrice MinimalPrice { get; set; }

    /// <summary>
    /// Gets or Sets StartingPrice
    /// </summary>
    [DataMember(Name="startingPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startingPrice")]
    public StartingPrice StartingPrice { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SellingMode {\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  MinimalPrice: ").Append(MinimalPrice).Append("\n");
      sb.Append("  StartingPrice: ").Append(StartingPrice).Append("\n");
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
