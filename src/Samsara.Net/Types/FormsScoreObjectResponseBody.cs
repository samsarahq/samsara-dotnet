using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Forms score object.
/// </summary>
[Serializable]
public record FormsScoreObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
