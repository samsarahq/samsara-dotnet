using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Alarms that have been emitted by the reefer.
/// </summary>
public record TrailerStatReeferAlarmWithDecorationsTypeResponseBody
{
    /// <summary>
    /// The alarms reported by the reefer.
    /// </summary>
    [JsonPropertyName("alarms")]
    public IEnumerable<TrailerStatReeferAlarmResponseBody> Alarms { get; set; } =
        new List<TrailerStatReeferAlarmResponseBody>();

    [JsonPropertyName("decorations")]
    public TrailerStatDecorationResponseBody? Decorations { get; set; }

    /// <summary>
    /// UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; set; }

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
