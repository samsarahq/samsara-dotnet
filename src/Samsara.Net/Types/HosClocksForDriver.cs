using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// HOS clock values for a specific driver, including remaining times and violations.
/// </summary>
public record HosClocksForDriver
{
    [JsonPropertyName("clocks")]
    public HosClocks? Clocks { get; set; }

    [JsonPropertyName("currentDutyStatus")]
    public CurrentDutyStatus? CurrentDutyStatus { get; set; }

    [JsonPropertyName("currentVehicle")]
    public VehicleTinyResponse? CurrentVehicle { get; set; }

    [JsonPropertyName("driver")]
    public DriverTinyResponse? Driver { get; set; }

    [JsonPropertyName("violations")]
    public HosViolations? Violations { get; set; }

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
