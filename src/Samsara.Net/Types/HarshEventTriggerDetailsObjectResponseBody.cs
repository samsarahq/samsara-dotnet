using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to Harsh Events
/// </summary>
public record HarshEventTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// On which harsh events to trigger on.
    /// </summary>
    [JsonPropertyName("types")]
    public IEnumerable<HarshEventTriggerDetailsObjectResponseBodyTypesItem> Types { get; set; } =
        new List<HarshEventTriggerDetailsObjectResponseBodyTypesItem>();

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
