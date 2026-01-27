using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Difficulty score won't be available if there is no data to compute it against.
/// </summary>
[Serializable]
public record DriverEfficiencyDifficultyScoreDataObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Represents the overall difficulty score. It has scores from 1 to 5.
    /// </summary>
    [JsonPropertyName("overallScore")]
    public string? OverallScore { get; set; }

    /// <summary>
    /// Represents the topography difficulty score. It has scores from 1 to 5.
    /// </summary>
    [JsonPropertyName("topographyScore")]
    public string? TopographyScore { get; set; }

    /// <summary>
    /// Represents the average vehicle weight score. It has scores from 1 to 5.
    /// </summary>
    [JsonPropertyName("vehicleWeightScore")]
    public string? VehicleWeightScore { get; set; }

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
