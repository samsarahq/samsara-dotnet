using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HarshEventTriggerDetailsObjectRequestBody
{
    /// <summary>
    /// On which harsh events to trigger on.
    /// </summary>
    [JsonPropertyName("types")]
    public IEnumerable<HarshEventTriggerDetailsObjectRequestBodyTypesItem> Types { get; set; } =
        new List<HarshEventTriggerDetailsObjectRequestBodyTypesItem>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
