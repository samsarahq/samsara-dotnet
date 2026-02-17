using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record GetReportRunsDataObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Columns of this report run.
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<ReportColumnsObjectResponseBody> Columns { get; set; } =
        new List<ReportColumnsObjectResponseBody>();

    /// <summary>
    /// Array where each inner array represents a row of data, and each element in the inner array is a value for the column. Inner array items are nullable, data types: double, string, timestamp as string in RFC3339 format. The number of columns defined in the report run is to the number of inner array items.
    /// </summary>
    [JsonPropertyName("rows")]
    public IEnumerable<IEnumerable<Dictionary<string, object?>>> Rows { get; set; } =
        new List<IEnumerable<Dictionary<string, object?>>>();

    /// <summary>
    /// Status of the report run.  Valid values: `complete`, `pending`, `failed`, `canceled`, `unknown`
    /// </summary>
    [JsonPropertyName("status")]
    public required GetReportRunsDataObjectResponseBodyStatus Status { get; set; }

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
