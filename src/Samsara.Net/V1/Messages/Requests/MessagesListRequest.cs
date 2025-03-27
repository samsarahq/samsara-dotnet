using Samsara.Net.Core;

namespace Samsara.Net.V1.Messages;

public record MessagesListRequest
{
    /// <summary>
    /// Time in unix milliseconds that represents the end of time range of messages to return. Used in combination with durationMs. Defaults to now.
    /// </summary>
    public long? EndMs { get; set; }

    /// <summary>
    /// Time in milliseconds that represents the duration before endMs to query. Defaults to 24 hours.
    /// </summary>
    public long? DurationMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
