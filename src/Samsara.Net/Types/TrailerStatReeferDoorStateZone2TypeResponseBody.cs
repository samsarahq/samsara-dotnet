using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The door state of the reefer.
/// </summary>
public record TrailerStatReeferDoorStateZone2TypeResponseBody
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
    public required TrailerStatReeferDoorStateZone2TypeResponseBodyValue Value { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
