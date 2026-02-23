using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LegacyApIs;

[Serializable]
public record V1GetVehicleHarshEventRequest
{
    /// <summary>
    /// ID of the vehicle. Must contain only digits 0-9.
    /// </summary>
    [JsonIgnore]
    public required long VehicleId { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the timestamp of a harsh event.
    /// </summary>
    [JsonIgnore]
    public required long Timestamp { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
