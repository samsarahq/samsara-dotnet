using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Work Order Related Item object.
/// </summary>
public record WorkOrderItemObjectRequestBody
{
    /// <summary>
    /// ID of the item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The type of item.  Valid values: `DVIR`, `FAULT`, `FORM`, `ISSUE`, `ITEM_TYPE_UNSPECIFIED`, `SCHEDULED_MAINTENANCE`
    /// </summary>
    [JsonPropertyName("type")]
    public required WorkOrderItemObjectRequestBodyType Type { get; set; }

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
