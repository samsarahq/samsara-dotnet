using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Reading Triggers.
/// </summary>
public record ReadingTriggerDetailsResponseBody
{
    [JsonPropertyName("asset")]
    public AlertObjectAssetResponseBody? Asset { get; set; }

    [JsonPropertyName("continuousThreshold")]
    public ContinuousReadingAlertThresholdResponseBody? ContinuousThreshold { get; set; }

    [JsonPropertyName("enumThreshold")]
    public EnumReadingAlertThresholdResponseBody? EnumThreshold { get; set; }

    /// <summary>
    /// The ID of the reading.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

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
