using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

public record AttributesDeleteAttributeRequest
{
    /// <summary>
    /// Denotes the type of entity, driver or asset.
    /// </summary>
    public required AttributesDeleteAttributeRequestEntityType EntityType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
