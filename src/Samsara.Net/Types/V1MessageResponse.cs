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
    /// ID of the driver for whom the message is sent to or sent by.
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
