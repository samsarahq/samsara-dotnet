using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosViolationDayObjectResponseBody
{
    /// <summary>
    /// The end time of the day on which the violation occurred in RFC 3339 format. This is determined by the driver's ELD start hour (00:00 or 12:00)
    /// </summary>
    [JsonPropertyName("endTime")]
    public required string EndTime { get; set; }

    /// <summary>
    /// The start time of the day on which the violation occurred in RFC 3339 format. This is determined by the driver's ELD start hour (00:00 or 12:00)
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

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
