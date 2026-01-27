using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a table form input field.
/// </summary>
[Serializable]
public record FormsTableValueObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of table columns.
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<FormsTableColumnObjectResponseBody> Columns { get; set; } =
        new List<FormsTableColumnObjectResponseBody>();

    /// <summary>
    /// List of table rows.
    /// </summary>
    [JsonPropertyName("rows")]
    public IEnumerable<FormsTableRowObjectResponseBody> Rows { get; set; } =
        new List<FormsTableRowObjectResponseBody>();

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
