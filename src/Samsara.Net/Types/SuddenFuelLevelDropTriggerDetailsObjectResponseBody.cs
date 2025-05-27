using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Sudden Fuel Level Drop
/// </summary>
public record SuddenFuelLevelDropTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// The minimum fuel level change in percents to trigger on. Need to be between 5 to 100.
    /// </summary>
    [JsonPropertyName("minFuelLevelChangeInPercents")]
    public required long MinFuelLevelChangeInPercents { get; set; }

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
