using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
