using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TinyTag
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("parentTagId")]
    public string? ParentTagId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
