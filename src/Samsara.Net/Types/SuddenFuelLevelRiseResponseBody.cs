using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Sudden Fuel Level Rise.
/// </summary>
public record SuddenFuelLevelRiseResponseBody
{
    /// <summary>
    /// The end time of the fuel level change in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("changeEndTime")]
    public DateTime? ChangeEndTime { get; set; }

    /// <summary>
    /// The start time of the fuel level change in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("changeStartTime")]
    public DateTime? ChangeStartTime { get; set; }

    [JsonPropertyName("driver")]
    public AlertObjectDriverResponseBody? Driver { get; set; }

    /// <summary>
    /// The fuel level after the sudden fuel level rise in millipercents.
    /// </summary>
    [JsonPropertyName("fuelLevelAfterMillipercent")]
    public int? FuelLevelAfterMillipercent { get; set; }

    /// <summary>
    /// The fuel level before the sudden fuel level rise in millipercents.
    /// </summary>
    [JsonPropertyName("fuelLevelBeforeMillipercent")]
    public int? FuelLevelBeforeMillipercent { get; set; }

    [JsonPropertyName("location")]
    public EventLocationResponseBody? Location { get; set; }

    [JsonPropertyName("vehicle")]
    public AlertObjectVehicleResponseBody? Vehicle { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
