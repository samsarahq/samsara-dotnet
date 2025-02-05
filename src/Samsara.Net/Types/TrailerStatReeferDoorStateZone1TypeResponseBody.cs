using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatReeferDoorStateZone1TypeResponseBody
{
    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The door state of zone 2 of the reefer.  Valid values: `open`, `closed`
    /// </summary>
    [JsonPropertyName("value")]
    public required TrailerStatReeferDoorStateZone1TypeResponseBodyValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
