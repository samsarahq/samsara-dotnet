using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Engine fault codes read from J1939, OBDII, and OEM vehicles.
/// </summary>
[Serializable]
public record VehicleStatsFaultCodesWithDecoration : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("canBusType")]
    public string? CanBusType { get; set; }

    [JsonPropertyName("decorations")]
    public VehicleStatsDecorations? Decorations { get; set; }

    [JsonPropertyName("j1939")]
    public VehicleStatsFaultCodesJ1939? J1939 { get; set; }

    [JsonPropertyName("obdii")]
    public VehicleStatsFaultCodesObdii? Obdii { get; set; }

    [JsonPropertyName("oem")]
    public VehicleStatsFaultCodesOem? Oem { get; set; }

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
