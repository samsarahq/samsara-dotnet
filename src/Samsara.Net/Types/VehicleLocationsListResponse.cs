using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// List of vehicle location events and pagination info.
/// </summary>
public record VehicleLocationsListResponse
{
    /// <summary>
    /// A list of vehicles and an array of location events for each vehicle.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<VehicleLocationsListResponseData> Data { get; set; } =
        new List<VehicleLocationsListResponseData>();

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
