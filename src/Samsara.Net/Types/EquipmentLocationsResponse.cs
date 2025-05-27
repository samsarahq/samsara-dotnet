using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The most recent equipment locations and pagination information
/// </summary>
public record EquipmentLocationsResponse
{
    /// <summary>
    /// List of the most recent locations for the specified units of equipment.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EquipmentLocationsResponseData> Data { get; set; } =
        new List<EquipmentLocationsResponseData>();

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
