using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentHeaderWithAdditionalFieldsResponseBody
{
    /// <summary>
    /// The unique Samsara ID of the equipment. This is automatically generated when the Equipment object is created. It cannot be changed.
    /// </summary>
    [JsonPropertyName("EquipmentID")]
    public string? EquipmentId { get; set; }

    /// <summary>
    /// The model of the equipment.
    /// </summary>
    [JsonPropertyName("Model")]
    public string? Model { get; set; }

    /// <summary>
    /// The make of the equipment.
    /// </summary>
    [JsonPropertyName("OEMName")]
    public string? OemName { get; set; }

    /// <summary>
    /// The PIN number of the equipment.
    /// </summary>
    [JsonPropertyName("PIN")]
    public string? Pin { get; set; }

    /// <summary>
    /// The serial number of the equipment.
    /// </summary>
    [JsonPropertyName("SerialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// Telematics unit install date in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonPropertyName("UnitInstallDateTime")]
    public string? UnitInstallDateTime { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
