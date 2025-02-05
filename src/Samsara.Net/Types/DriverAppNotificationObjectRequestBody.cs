using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverAppNotificationObjectRequestBody
{
    [JsonPropertyName("inAppNotificationOptions")]
    public InAppNotificationOptionsObjectRequestBody? InAppNotificationOptions { get; set; }

    [JsonPropertyName("pushNotificationOptions")]
    public PushNotificationOptionsObjectRequestBody? PushNotificationOptions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
