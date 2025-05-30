using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverVehicleAssignmentsV2GetDriverVehicleAssignmentsResponseBody
{
    /// <summary>
    /// List of driver assignment objects and their respective vehcile and driver info.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DriverVehicleAssignmentV2ObjectResponseBody> Data { get; set; } =
        new List<DriverVehicleAssignmentV2ObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

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
