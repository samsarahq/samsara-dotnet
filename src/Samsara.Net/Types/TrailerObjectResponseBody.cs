using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerObjectResponseBody
{
    /// <summary>
    /// Samsara ID of the trailer.
    /// </summary>
    [JsonPropertyName("trailerId")]
    public required string TrailerId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
