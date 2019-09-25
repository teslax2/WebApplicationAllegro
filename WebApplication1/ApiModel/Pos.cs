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
  public class Pos {
    /// <summary>
    /// UUID. When creating a point of service (Post) the field is ignored. It is required when updating (Put) a point of service.
    /// </summary>
    /// <value>UUID. When creating a point of service (Post) the field is ignored. It is required when updating (Put) a point of service.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// ID from external client system.
    /// </summary>
    /// <value>ID from external client system.</value>
    [DataMember(Name="externalId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "externalId")]
    public string ExternalId { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Seller
    /// </summary>
    [DataMember(Name="seller", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seller")]
    public Seller Seller { get; set; }

    /// <summary>
    /// Indicates point type. The only valid value so far is PICKUP_POINT.
    /// </summary>
    /// <value>Indicates point type. The only valid value so far is PICKUP_POINT.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or Sets PhoneNumber
    /// </summary>
    [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Possible empty list of opening hours.
    /// </summary>
    /// <value>Possible empty list of opening hours.</value>
    [DataMember(Name="openHours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "openHours")]
    public List<OpenHour> OpenHours { get; set; }

    /// <summary>
    /// Delivery time / Time period for receipt. Date format ISO 8601 e.g. 'PT24H'
    /// </summary>
    /// <value>Delivery time / Time period for receipt. Date format ISO 8601 e.g. 'PT24H'</value>
    [DataMember(Name="serviceTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serviceTime")]
    public string ServiceTime { get; set; }

    /// <summary>
    /// An empty list of payment types is available.
    /// </summary>
    /// <value>An empty list of payment types is available.</value>
    [DataMember(Name="payments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "payments")]
    public List<Payment> Payments { get; set; }

    /// <summary>
    /// Confirmation method: AWAIT_CONTACT - We will inform you about the time of receipt, CALL_US - Please make an appointment, CONTACT_NOT_REQUIRED - Contact is not required.
    /// </summary>
    /// <value>Confirmation method: AWAIT_CONTACT - We will inform you about the time of receipt, CALL_US - Please make an appointment, CONTACT_NOT_REQUIRED - Contact is not required.</value>
    [DataMember(Name="confirmationType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "confirmationType")]
    public string ConfirmationType { get; set; }

    /// <summary>
    /// Point of service status: ACTIVE - active, TEMPORARILY_CLOSED - temporarily closed, CLOSED_DOWN - closed down, DELETED - deleted.
    /// </summary>
    /// <value>Point of service status: ACTIVE - active, TEMPORARILY_CLOSED - temporarily closed, CLOSED_DOWN - closed down, DELETED - deleted.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Creation date. Date format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ When creating (Post) or updating (Put) a point of service (Post) the field is ignored.
    /// </summary>
    /// <value>Creation date. Date format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ When creating (Post) or updating (Put) a point of service (Post) the field is ignored.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// Modification date. Date format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ When creating (Post) or updating (Put) a point of service (Post) the field is ignored.
    /// </summary>
    /// <value>Modification date. Date format (ISO 8601) - yyyy-MM-dd'T'HH:mm:ss.SSSZ When creating (Post) or updating (Put) a point of service (Post) the field is ignored.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public string UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Pos {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Seller: ").Append(Seller).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  OpenHours: ").Append(OpenHours).Append("\n");
      sb.Append("  ServiceTime: ").Append(ServiceTime).Append("\n");
      sb.Append("  Payments: ").Append(Payments).Append("\n");
      sb.Append("  ConfirmationType: ").Append(ConfirmationType).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
