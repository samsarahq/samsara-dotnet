using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Driver app notification settings
/// </summary>
public record DriverAppNotificationObjectResponseBody
{
    [JsonPropertyName("inAppNotificationOptions")]
    public InAppNotificationOptionsObjectResponseBody? InAppNotificationOptions { get; set; }

    [JsonPropertyName("pushNotificationOptions")]
    public PushNotificationOptionsObjectResponseBody? PushNotificationOptions { get; set; }

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
