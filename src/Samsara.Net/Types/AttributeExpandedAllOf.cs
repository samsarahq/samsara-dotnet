using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AttributeExpandedAllOf
{
    /// <summary>
    /// Entities that this attribute is applied onto
    /// </summary>
    [JsonPropertyName("entities")]
    public IEnumerable<AttributeEntity> Entities { get; set; } = new List<AttributeEntity>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
