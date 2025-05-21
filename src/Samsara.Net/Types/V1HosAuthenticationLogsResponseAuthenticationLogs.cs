using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1HosAuthenticationLogsResponseAuthenticationLogs
{
    /// <summary>
    /// The log type - one of 'signin' or 'signout'
    /// </summary>
    [JsonPropertyName("actionType")]
    public string? ActionType { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("addressName")]
    public string? AddressName { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("city")]
    public string? City { get; set; }

    /// <summary>
    /// The time at which the event was recorded in UNIX milliseconds.
    /// </summary>
    [JsonPropertyName("happenedAtMs")]
    public long? HappenedAtMs { get; set; }

    /// <summary>
    /// DEPRECATED: THIS FIELD MAY NOT BE POPULATED
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

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
