using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains equipment fields.
/// </summary>
[Serializable]
public record AempEquipmentWithAdditionalFieldsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("CumulativeOperatingHours")]
    public CumulativeOperatingHoursResponseBody? CumulativeOperatingHours { get; set; }

    [JsonPropertyName("DEFRemaining")]
    public DefRemainingResponseBody? DefRemaining { get; set; }

    [JsonPropertyName("Distance")]
    public DistanceResponseBody? Distance { get; set; }

    [JsonPropertyName("EngineStatus")]
    public EngineStatusResponseBody? EngineStatus { get; set; }

    [JsonPropertyName("EquipmentHeader")]
    public required EquipmentHeaderWithAdditionalFieldsResponseBody EquipmentHeader { get; set; }

    [JsonPropertyName("FuelRemaining")]
    public FuelRemainingResponseBody? FuelRemaining { get; set; }

    [JsonPropertyName("Location")]
    public required LocationResponseBody Location { get; set; }

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
