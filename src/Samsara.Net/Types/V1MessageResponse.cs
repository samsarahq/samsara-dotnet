using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1MessageResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// ID of the driver associated with this message row. For organizations using Messages v2, this field uses 0 as a sentinel when the message belongs to a non–single-driver channel (for example Announcements channel, multi-member groups, or Driver-to-Admin channels): the API returns one row for the message instead of one row per recipient driver. For 1:1 conversations, this is the driver’s ID. Integrations that only need 1:1 messages should filter responses where driverId != 0.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required long DriverId { get; set; }

    /// <summary>
    /// True if the message was read by the recipient.
    /// </summary>
    [JsonPropertyName("isRead")]
    public required bool IsRead { get; set; }

    [JsonPropertyName("sender")]
    public required V1MessageSender Sender { get; set; }

    /// <summary>
    /// The time in Unix epoch milliseconds that the message is sent to the recipient.
    /// </summary>
    [JsonPropertyName("sentAtMs")]
    public required long SentAtMs { get; set; }

    /// <summary>
    /// The text sent in the message.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

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
