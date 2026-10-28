using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[Serializable]
public record DeleteAttributesRequest
{
    /// <summary>
    /// Samsara-provided UUID of the attribute.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Denotes the type of entity, driver, asset, or workOrder. `workOrder` requires work order attributes to be enabled for the organization.
    /// </summary>
    [JsonIgnore]
    public required DeleteAttributesRequestEntityType EntityType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
