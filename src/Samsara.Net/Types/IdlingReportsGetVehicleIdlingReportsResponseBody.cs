using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IdlingReportsGetVehicleIdlingReportsResponseBody
{
    /// <summary>
    /// Multiple idling events.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<IdlingReportEventResponseBody> Data { get; set; } =
        new List<IdlingReportEventResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    /// <summary>
    /// The requested end time in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestEndTime")]
    public required string RequestEndTime { get; set; }

    /// <summary>
    /// The requested start time in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestStartTime")]
    public required string RequestStartTime { get; set; }

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
