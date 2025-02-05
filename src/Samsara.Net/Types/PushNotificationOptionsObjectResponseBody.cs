using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PushNotificationOptionsObjectResponseBody
{
    /// <summary>
    /// Whether push notifications are enabled.
    /// </summary>
    [JsonPropertyName("isEnabled")]
    public required bool IsEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
