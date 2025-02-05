using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ActionParamsObjectResponseBody
{
    [JsonPropertyName("driverAppNotification")]
    public DriverAppNotificationObjectResponseBody? DriverAppNotification { get; set; }

    /// <summary>
    /// Recipient of the action.
    /// </summary>
    [JsonPropertyName("recipients")]
    public IEnumerable<RecipientObjectResponseBody>? Recipients { get; set; }

    [JsonPropertyName("webhooks")]
    public WebhookParamsObjectResponseBody? Webhooks { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
