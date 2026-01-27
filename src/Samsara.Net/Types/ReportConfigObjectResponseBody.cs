using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record ReportConfigObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Columns included in the report configuration.
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<ColumnResponseBody> Columns { get; set; } = new List<ColumnResponseBody>();

    /// <summary>
    /// ID of dataset for report configuration.
    /// </summary>
    [JsonPropertyName("datasetId")]
    public required string DatasetId { get; set; }

    [JsonPropertyName("filters")]
    public FiltersResponseBody? Filters { get; set; }

    /// <summary>
    /// ID of report configuration.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of report configuration.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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
