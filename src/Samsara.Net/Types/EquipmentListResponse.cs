using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// List of all equipment objects, and pagination information.
/// </summary>
public record EquipmentListResponse
{
    /// <summary>
    /// List of equipment objects.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EquipmentObject> Data { get; set; } = new List<EquipmentObject>();

    [JsonPropertyName("pagination")]
    public required PaginationResponse Pagination { get; set; }

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
