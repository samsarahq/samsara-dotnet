using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentCreateFieldsItemMultipleChoiceValueItem
{
    [JsonPropertyName("selected")]
    public bool? Selected { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
