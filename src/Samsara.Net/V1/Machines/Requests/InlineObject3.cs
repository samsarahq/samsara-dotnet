using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.V1.Machines;

public record InlineObject3
{
    /// <summary>
    /// End of the time range, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("endMs")]
    public required int EndMs { get; set; }

    /// <summary>
    /// Beginning of the time range, specified in milliseconds UNIX time.
    /// </summary>
    [JsonPropertyName("startMs")]
    public required int StartMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
