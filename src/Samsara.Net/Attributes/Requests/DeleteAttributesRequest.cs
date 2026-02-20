using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[Serializable]
public record DeleteAttributesRequest
{
    /// <summary>
    /// Denotes the type of entity, driver or asset.
    /// </summary>
    [JsonIgnore]
    public required DeleteAttributesRequestEntityType EntityType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
