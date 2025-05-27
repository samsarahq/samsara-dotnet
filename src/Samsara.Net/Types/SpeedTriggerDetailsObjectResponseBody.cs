using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Speed
/// </summary>
public record SpeedTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// The number of milliseconds the trigger needs to stay active before alerting.
    /// </summary>
    [JsonPropertyName("minDurationMilliseconds")]
    public required long MinDurationMilliseconds { get; set; }

    /// <summary>
    /// How to evaluate the threshold.  Valid values: `GREATER`, `LESS`
    /// </summary>
    [JsonPropertyName("operation")]
    public required SpeedTriggerDetailsObjectResponseBodyOperation Operation { get; set; }

    /// <summary>
    /// The speed threshold value.
    /// </summary>
    [JsonPropertyName("speedKilometersPerHour")]
    public required long SpeedKilometersPerHour { get; set; }

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
