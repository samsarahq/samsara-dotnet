using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ActionParamsObjectRequestBody
{
    [JsonPropertyName("driverAppNotification")]
    public DriverAppNotificationObjectRequestBody? DriverAppNotification { get; set; }

    /// <summary>
    /// Recipient of the action.
    /// </summary>
    [JsonPropertyName("recipients")]
    public IEnumerable<RecipientObjectRequestBody>? Recipients { get; set; }

    [JsonPropertyName("webhooks")]
    public WebhookParamsObjectRequestBody? Webhooks { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
