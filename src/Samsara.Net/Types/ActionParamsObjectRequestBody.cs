using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The action type specific details. Set webhookIds for Slack or Webhook actions. Set recipients for Notifications. Set driverAppNotification for Driver App Push. Other action types don't need to set a param.
/// </summary>
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
