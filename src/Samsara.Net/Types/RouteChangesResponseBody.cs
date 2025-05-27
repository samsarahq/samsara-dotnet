using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A diff of the changes for a route update.
/// </summary>
public record RouteChangesResponseBody
{
    [JsonPropertyName("after")]
    public required MinimalRouteAuditLogsResponseBody After { get; set; }

    [JsonPropertyName("before")]
    public required MinimalRouteAuditLogsResponseBody Before { get; set; }

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
