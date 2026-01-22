using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Messages;

[Serializable]
public record V1GetMessagesRequest
{
    /// <summary>
    /// Time in unix milliseconds that represents the end of time range of messages to return. Used in combination with durationMs. Defaults to now.
    /// </summary>
    [JsonIgnore]
    public long? EndMs { get; set; }

    /// <summary>
    /// Time in milliseconds that represents the duration before endMs to query. Defaults to 24 hours.
    /// </summary>
    [JsonIgnore]
    public long? DurationMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
