using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItemFindCopies
{
    /// <summary>
    /// The orientation angle tolerance (+/- °)
    /// </summary>
    [JsonPropertyName("angleTolerance")]
    public long? AngleTolerance { get; set; }

    /// <summary>
    /// The number of copies found
    /// </summary>
    [JsonPropertyName("foundCount")]
    public long? FoundCount { get; set; }

    /// <summary>
    /// The maximum number of copies allowed
    /// </summary>
    [JsonPropertyName("maxCount")]
    public long? MaxCount { get; set; }

    /// <summary>
    /// The minimum number of copies allowed
    /// </summary>
    [JsonPropertyName("minCount")]
    public long? MinCount { get; set; }

    /// <summary>
    /// The minimum required similarity (in %) of a found copy compared to the configured match region
    /// </summary>
    [JsonPropertyName("threshold")]
    public long? Threshold { get; set; }

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
