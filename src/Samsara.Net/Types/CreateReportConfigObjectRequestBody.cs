using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains report config for a given report run.
/// </summary>
[Serializable]
public record CreateReportConfigObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Columns to include in the report. Only one of ID or datasetId and columns must be provided.
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<CreateReportConfigColumnRequestBody>? Columns { get; set; }

    /// <summary>
    /// ID of the dataset that is going to be used for the report. Only one of ID or datasetId and columns must be provided.
    /// </summary>
    [JsonPropertyName("datasetId")]
    public string? DatasetId { get; set; }

    [JsonPropertyName("filters")]
    public FiltersRequestBody? Filters { get; set; }

    /// <summary>
    /// ID of the custom report config. Only one of ID or datasetId and columns must be provided.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
