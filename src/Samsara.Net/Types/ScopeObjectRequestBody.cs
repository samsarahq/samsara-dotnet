using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// What the triggers are scoped to. These are the objects this alert applies to.
/// </summary>
public record ScopeObjectRequestBody
{
    /// <summary>
    /// Whether it applies to all applicable objects.
    /// </summary>
    [JsonPropertyName("all")]
    public required bool All { get; set; }

    /// <summary>
    /// The assets these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("assets")]
    public IEnumerable<TinyAssetObjectRequestBody>? Assets { get; set; }

    /// <summary>
    /// The drivers these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("drivers")]
    public IEnumerable<TinyDriverObjectRequestBody>? Drivers { get; set; }

    /// <summary>
    /// The tags these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<GoaTagTinyResponseRequestBody>? Tags { get; set; }

    /// <summary>
    /// The widgets these triggers are scoped to.
    /// </summary>
    [JsonPropertyName("widgets")]
    public IEnumerable<TinyWidgetObjectRequestBody>? Widgets { get; set; }

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
