using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Messages;

public record InlineObject2
{
    /// <summary>
    /// IDs of the drivers for whom the messages are sent to.
    /// </summary>
    [JsonPropertyName("driverIds")]
    public IEnumerable<long> DriverIds { get; set; } = new List<long>();

    /// <summary>
    /// The text sent in the message. Max 2500 characters allowed.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
