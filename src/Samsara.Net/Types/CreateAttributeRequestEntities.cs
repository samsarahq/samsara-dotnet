using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CreateAttributeRequestEntities
{
    /// <summary>
    /// Entity id, based on the entity type.
    /// </summary>
    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Number values that can be associated with this attribute
    /// </summary>
    [JsonPropertyName("numberValues")]
    public IEnumerable<double>? NumberValues { get; set; }

    /// <summary>
    /// String values that can be associated with this attribute
    /// </summary>
    [JsonPropertyName("stringValues")]
    public IEnumerable<string>? StringValues { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
