using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PostMediaRetrievalObjectResponseBody
{
    /// <summary>
    /// Quota status for this media capture request. Examples: Current monthly usage is 80000.4 seconds of high-res video out of 900000.0 available.
    /// </summary>
    [JsonPropertyName("quotaStatus")]
    public required string QuotaStatus { get; set; }

    /// <summary>
    /// Retrieval ID associated with this media capture request. Examples: 2308cec4-82e0-46f1-8b3c-a3592e5cc21e
    /// </summary>
    [JsonPropertyName("retrievalId")]
    public required string RetrievalId { get; set; }

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
