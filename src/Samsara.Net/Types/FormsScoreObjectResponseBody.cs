using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms score object.
/// </summary>
public record FormsScoreObjectResponseBody
{
    /// <summary>
    /// Total possible points of the form submission.
    /// </summary>
    [JsonPropertyName("maxPoints")]
    public required double MaxPoints { get; set; }

    /// <summary>
    /// Percentage score of the form submission, calculated as scorePoints / maxPoints.
    /// </summary>
    [JsonPropertyName("scorePercent")]
    public required double ScorePercent { get; set; }

    /// <summary>
    /// Score, in points, of the form submission.
    /// </summary>
    [JsonPropertyName("scorePoints")]
    public required double ScorePoints { get; set; }

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
