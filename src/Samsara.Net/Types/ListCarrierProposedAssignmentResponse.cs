using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A list of carrier-proposed assignments and pagination information.
/// </summary>
public record ListCarrierProposedAssignmentResponse
{
    /// <summary>
    /// A list of carrier-proposed assignments
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<CarrierProposedAssignment> Data { get; set; } =
        new List<CarrierProposedAssignment>();

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
