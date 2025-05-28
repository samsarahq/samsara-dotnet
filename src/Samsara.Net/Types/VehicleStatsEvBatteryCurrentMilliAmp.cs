using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Battery current for electric and hybrid vehicles in milli amps. Not all EV and HEVs may report this field.
/// </summary>
public record VehicleStatsEvBatteryCurrentMilliAmp
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Battery current for electric and hybrid vehicles in milli amps.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

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
