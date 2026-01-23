using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// singleDriverEfficiencyByVehicleDataObject
/// </summary>
[Serializable]
public record SingleDriverEfficiencyByVehicleDataObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("difficultyScore")]
    public DriverEfficiencyDifficultyScoreDataObjectResponseBody? DifficultyScore { get; set; }

    [JsonPropertyName("percentageData")]
    public DriverEfficiencyPercentageDataObjectResponseBody? PercentageData { get; set; }

    [JsonPropertyName("rawData")]
    public DriverEfficiencyRawDataObjectResponseBody? RawData { get; set; }

    [JsonPropertyName("scoreData")]
    public DriverEfficiencyDataObjectResponseBody? ScoreData { get; set; }

    /// <summary>
    /// ID of the vehicle.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public required string VehicleId { get; set; }

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
