using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Safety;

[Serializable]
public record V1GetVehicleSafetyScoreRequest
{
    /// <summary>
    /// ID of the vehicle. Must contain only digits 0-9.
    /// </summary>
    [JsonIgnore]
    public required long VehicleId { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the start of the period to fetch, inclusive. Used in combination with endMs. Total duration (endMs - startMs) must be greater than or equal to 1 hour.
    /// </summary>
    [JsonIgnore]
    public required long StartMs { get; set; }

    /// <summary>
    /// Timestamp in milliseconds representing the end of the period to fetch, inclusive. Used in combination with startMs. Total duration (endMs - startMs) must be greater than or equal to 1 hour.
    /// </summary>
    [JsonIgnore]
    public required long EndMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
