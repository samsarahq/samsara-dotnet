using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// singleDriverEfficiencyByDriverDataObject
/// </summary>
public record SingleDriverEfficiencyByDriverDataObjectResponseBody
{
    [JsonPropertyName("difficultyScore")]
    public DriverEfficiencyDifficultyScoreDataObjectResponseBody? DifficultyScore { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required string DriverId { get; set; }

    [JsonPropertyName("percentageData")]
    public DriverEfficiencyPercentageDataObjectResponseBody? PercentageData { get; set; }

    [JsonPropertyName("rawData")]
    public DriverEfficiencyRawDataObjectResponseBody? RawData { get; set; }

    [JsonPropertyName("scoreData")]
    public DriverEfficiencyDataObjectResponseBody? ScoreData { get; set; }

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
