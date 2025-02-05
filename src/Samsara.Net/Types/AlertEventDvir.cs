using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AlertEventDvir
{
    /// <summary>
    /// ID of the DVIR
    /// </summary>
    [JsonPropertyName("dvirId")]
    public string? DvirId { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertEventDvirVehicle? Vehicle { get; set; }

    [JsonPropertyName("trailer")]
    public AlertEventDvirTrailer? Trailer { get; set; }

    [JsonPropertyName("driver")]
    public AlertEventDvirDriver? Driver { get; set; }

    /// <summary>
    /// Odometer value in meters
    /// </summary>
    [JsonPropertyName("odometer")]
    public int? Odometer { get; set; }

    [JsonPropertyName("inspectionType")]
    public AlertEventDvirInspectionType? InspectionType { get; set; }

    [JsonPropertyName("safetyStatus")]
    public AlertEventDvirSafetyStatus? SafetyStatus { get; set; }

    [JsonPropertyName("defects")]
    public IEnumerable<AlertEventDvirDefectsItem>? Defects { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
