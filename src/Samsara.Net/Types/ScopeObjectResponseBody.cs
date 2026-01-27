using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// What the triggers are scoped to. These are the objects this alert applies to.
/// </summary>
[Serializable]
public record ScopeObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether it applies to all applicable objects.
    /// </summary>
    [JsonPropertyName("all")]
    public required bool All { get; set; }

    /// <summary>
    /// The assets these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("assets")]
    public IEnumerable<TinyAssetObjectResponseBody>? Assets { get; set; }

    /// <summary>
    /// The drivers these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("drivers")]
    public IEnumerable<TinyDriverObjectResponseBody>? Drivers { get; set; }

    /// <summary>
    /// The tags these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseResponseBody>? Tags { get; set; }

    /// <summary>
    /// The widgets these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("widgets")]
    public IEnumerable<TinyWidgetObjectResponseBody>? Widgets { get; set; }

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
