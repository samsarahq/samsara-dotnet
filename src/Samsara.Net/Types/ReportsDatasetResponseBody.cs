using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Information about a dataset.
/// </summary>
[Serializable]
public record ReportsDatasetResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Display name of the dataset.
    /// </summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>
    /// Fields within the dataset.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<ReportsDatasetFieldResponseBody> Fields { get; set; } =
        new List<ReportsDatasetFieldResponseBody>();

    /// <summary>
    /// Indicates if the dataset has a time range filter.
    /// </summary>
    [JsonPropertyName("hasTimeRangeFilter")]
    public required bool HasTimeRangeFilter { get; set; }

    /// <summary>
    /// Unique ID of the dataset.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Time range limit for the dataset measured in days.
    /// </summary>
    [JsonPropertyName("timeRangeLimitDays")]
    public long? TimeRangeLimitDays { get; set; }

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
