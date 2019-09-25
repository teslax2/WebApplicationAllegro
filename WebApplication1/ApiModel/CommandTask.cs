using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace WebApplication1.ApiModel {

  /// <summary>
  /// Status of single command task.
  /// </summary>
  [DataContract]
  public class CommandTask {
    /// <summary>
    /// Modified field as JSON path.
    /// </summary>
    /// <value>Modified field as JSON path.</value>
    [DataMember(Name="field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field")]
    public string Field { get; set; }

    /// <summary>
    /// Date of completion of the modification. Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ
    /// </summary>
    /// <value>Date of completion of the modification. Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ</value>
    [DataMember(Name="finishedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "finishedAt")]
    public DateTime? FinishedAt { get; set; }

    /// <summary>
    /// General fail reason. You should check the errors structure to get more detailed information of the encountered errors.
    /// </summary>
    /// <value>General fail reason. You should check the errors structure to get more detailed information of the encountered errors.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Offer
    /// </summary>
    [DataMember(Name="offer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer")]
    public OfferId Offer { get; set; }

    /// <summary>
    /// Date of the modification schedule. Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ
    /// </summary>
    /// <value>Date of the modification schedule. Format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ</value>
    [DataMember(Name="scheduledAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scheduledAt")]
    public DateTime? ScheduledAt { get; set; }

    /// <summary>
    /// Available statuses: NEW, SUCCESS, FAIL
    /// </summary>
    /// <value>Available statuses: NEW, SUCCESS, FAIL</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// The list of error objects explaining the problems with command processing for the given offer.
    /// </summary>
    /// <value>The list of error objects explaining the problems with command processing for the given offer.</value>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<Error> Errors { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CommandTask {\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Offer: ").Append(Offer).Append("\n");
      sb.Append("  ScheduledAt: ").Append(ScheduledAt).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
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
