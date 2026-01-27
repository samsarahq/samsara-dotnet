using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a check boxes form input field.
/// </summary>
[Serializable]
public record FormsCheckBoxesValueObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of selected options.
    /// </summary>
    [JsonPropertyName("value")]
    public IEnumerable<string> Value { get; set; } = new List<string>();

    /// <summary>
    /// List of selected option IDs.
    /// </summary>
    [JsonPropertyName("valueIds")]
    public IEnumerable<string> ValueIds { get; set; } = new List<string>();

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
