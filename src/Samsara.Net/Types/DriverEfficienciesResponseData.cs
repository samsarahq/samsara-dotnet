using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record DriverEfficienciesResponseData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A list of driver and associated vehicle efficiency data.
    /// </summary>
    [JsonPropertyName("driverSummaries")]
    public IEnumerable<DriverEfficiency>? DriverSummaries { get; set; }

    /// <summary>
    /// End time of the window for which this efficiency report was computed. Will be a UTC timestamp in RFC 3339 format. For example: `2020-03-16T16:00:00Z`
    /// </summary>
    [JsonPropertyName("summaryEndTime")]
    public DateTime? SummaryEndTime { get; set; }

    /// <summary>
    /// Start time of the window for which this efficiency report was computed. Will be a UTC timestamp in RFC 3339 format. For example: `2020-03-15T16:00:00Z`
    /// </summary>
    [JsonPropertyName("summaryStartTime")]
    public DateTime? SummaryStartTime { get; set; }

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
