using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// bid response
  /// </summary>
  [DataContract]
  public class MyBidResponse {
    /// <summary>
    /// Gets or Sets MaxAmount
    /// </summary>
    [DataMember(Name="maxAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxAmount")]
    public MaxPrice MaxAmount { get; set; }

    /// <summary>
    /// This indicates if the minimal price of the auction has been met or is not set at all. A minimal price can be set by the seller and is the minimum amount the seller is willing to sell the item for. If the highest bid is not higher than the minimal price when the auction ends, the listing ends and the item is not sold.
    /// </summary>
    /// <value>This indicates if the minimal price of the auction has been met or is not set at all. A minimal price can be set by the seller and is the minimum amount the seller is willing to sell the item for. If the highest bid is not higher than the minimal price when the auction ends, the listing ends and the item is not sold.</value>
    [DataMember(Name="minimalPriceMet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minimalPriceMet")]
    public bool? MinimalPriceMet { get; set; }

    /// <summary>
    /// Is this bid currently winning?
    /// </summary>
    /// <value>Is this bid currently winning?</value>
    [DataMember(Name="highBidder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highBidder")]
    public bool? HighBidder { get; set; }

    /// <summary>
    /// Gets or Sets Auction
    /// </summary>
    [DataMember(Name="auction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "auction")]
    public AuctionDetails Auction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MyBidResponse {\n");
      sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
      sb.Append("  MinimalPriceMet: ").Append(MinimalPriceMet).Append("\n");
      sb.Append("  HighBidder: ").Append(HighBidder).Append("\n");
      sb.Append("  Auction: ").Append(Auction).Append("\n");
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
