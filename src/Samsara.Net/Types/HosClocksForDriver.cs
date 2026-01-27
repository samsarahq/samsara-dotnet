using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// HOS clock values for a specific driver, including remaining times and violations.
/// </summary>
[Serializable]
public record HosClocksForDriver : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
