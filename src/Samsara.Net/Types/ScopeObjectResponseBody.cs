using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ScopeObjectResponseBody
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
