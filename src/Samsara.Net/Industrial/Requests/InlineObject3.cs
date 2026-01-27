using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Industrial;

[Serializable]
public record InlineObject3
{
    /// <summary>
    /// End of the time range, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("endMs")]
    public required long EndMs { get; set; }

    /// <summary>
    /// Beginning of the time range, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("startMs")]
    public required long StartMs { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
