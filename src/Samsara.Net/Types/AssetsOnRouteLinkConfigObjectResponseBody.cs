using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Configuration details specific to the 'By Recurring Route' Live Sharing Link.
/// </summary>
public record AssetsOnRouteLinkConfigObjectResponseBody
{
    /// <summary>
    /// Samsara ID of the recurring route.
    /// </summary>
    [JsonPropertyName("recurringRouteId")]
    public required string RecurringRouteId { get; set; }

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
