using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

public record AttributesDeleteRequest
{
    /// <summary>
    /// Denotes the type of entity, driver or asset.
    /// </summary>
    public required AttributesDeleteRequestEntityType EntityType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
