using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
