using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IdlingReportEventResponseBody
{
    [JsonPropertyName("address")]
    public required IdlingReportEventAddressResponseBody Address { get; set; }

    /// <summary>
    /// The duration of this idling event in milliseconds.
    /// </summary>
    [JsonPropertyName("durationMs")]
    public required long DurationMs { get; set; }

    /// <summary>
    /// The end time of this idling event in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// The amount of fuel consumed in milliliters during this idling event.
    /// </summary>
    [JsonPropertyName("fuelConsumptionMl")]
    public required double FuelConsumptionMl { get; set; }

    /// <summary>
    /// Whether or not power take-off was active during this idling event.
    /// </summary>
    [JsonPropertyName("isPtoActive")]
    public required bool IsPtoActive { get; set; }

    /// <summary>
    /// The start time of this idling event in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    [JsonPropertyName("vehicle")]
    public required GoaVehicleTinyResponseResponseBody Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
