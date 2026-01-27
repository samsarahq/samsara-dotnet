using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a row in a table form input field.
/// </summary>
[Serializable]
public record FormSubmissionRequestTableRowObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of cells in the row.
    /// </summary>
    [JsonPropertyName("cells")]
    public IEnumerable<FormSubmissionRequestTableCellObjectRequestBody> Cells { get; set; } =
        new List<FormSubmissionRequestTableCellObjectRequestBody>();

    /// <summary>
    /// Unique identifier for the row.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
