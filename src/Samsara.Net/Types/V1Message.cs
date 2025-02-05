using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1Message
{
    /// <summary>
    /// ID of the driver for whom the message is sent to or sent by.
    /// </summary>
    [JsonPropertyName("driverId")]
    public required long DriverId { get; set; }

    /// <summary>
    /// The text sent in the message.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
