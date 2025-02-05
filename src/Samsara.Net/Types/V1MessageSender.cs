using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1MessageSender
{
    /// <summary>
    /// Name of user that is sending the message.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Type of user that is sending the message. It will be either dispatch or driver.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
