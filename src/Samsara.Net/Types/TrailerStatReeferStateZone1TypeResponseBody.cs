using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TrailerStatReeferStateZone1TypeResponseBody
{
    /// <summary>
    /// The substate zone 1 of the reefer, if available.
    /// </summary>
    [JsonPropertyName("substateValue")]
    public string? SubstateValue { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The state zone 1 of the reefer.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
