using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverAppNotificationObjectResponseBody
{
    [JsonPropertyName("inAppNotificationOptions")]
    public InAppNotificationOptionsObjectResponseBody? InAppNotificationOptions { get; set; }

    [JsonPropertyName("pushNotificationOptions")]
    public PushNotificationOptionsObjectResponseBody? PushNotificationOptions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
