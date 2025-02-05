using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshEventTriggerDetailsObjectResponseBody
{
    /// <summary>
    /// On which harsh events to trigger on.
    /// </summary>
    [JsonPropertyName("types")]
    public IEnumerable<HarshEventTriggerDetailsObjectResponseBodyTypesItem> Types { get; set; } =
        new List<HarshEventTriggerDetailsObjectResponseBodyTypesItem>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
