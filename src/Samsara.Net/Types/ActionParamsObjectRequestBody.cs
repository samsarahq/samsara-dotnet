using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The action type specific details. Set webhookIds for Slack or Webhook actions. Set recipients for Notifications. Set driverAppNotification for Driver App Push. Other action types don't need to set a param.
/// </summary>
[Serializable]
public record ActionParamsObjectRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("driverAppNotification")]
    public DriverAppNotificationObjectRequestBody? DriverAppNotification { get; set; }

    /// <summary>
    /// Recipient of the action.
    /// </summary>
    [JsonPropertyName("recipients")]
    public IEnumerable<RecipientObjectRequestBody>? Recipients { get; set; }

    [JsonPropertyName("webhooks")]
    public WebhookParamsObjectRequestBody? Webhooks { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
