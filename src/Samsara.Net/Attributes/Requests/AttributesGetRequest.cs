using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

public record AttributesGetRequest
{
    /// <summary>
    /// Denotes the type of entity, driver or asset.
    /// </summary>
    public required AttributesGetRequestEntityType EntityType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
