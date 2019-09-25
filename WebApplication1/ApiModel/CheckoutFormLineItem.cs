using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Order item
  /// </summary>
  [DataContract]
  public class CheckoutFormLineItem {
    /// <summary>
    /// Line item identifier
    /// </summary>
    /// <value>Line item identifier</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets Offer
    /// </summary>
    [DataMember(Name="offer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer")]
    public OfferReference Offer { get; set; }

    /// <summary>
    /// quantity
    /// </summary>
    /// <value>quantity</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Gets or Sets OriginalPrice
    /// </summary>
    [DataMember(Name="originalPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "originalPrice")]
    public Price OriginalPrice { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public Price Price { get; set; }

    /// <summary>
    /// Gets or Sets SelectedAdditionalServices
    /// </summary>
    [DataMember(Name="selectedAdditionalServices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selectedAdditionalServices")]
    public List<CheckoutFormAdditionalService> SelectedAdditionalServices { get; set; }

    /// <summary>
    /// ISO date when offer was bought
    /// </summary>
    /// <value>ISO date when offer was bought</value>
    [DataMember(Name="boughtAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "boughtAt")]
    public DateTime? BoughtAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CheckoutFormLineItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Offer: ").Append(Offer).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  SelectedAdditionalServices: ").Append(SelectedAdditionalServices).Append("\n");
      sb.Append("  BoughtAt: ").Append(BoughtAt).Append("\n");
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
