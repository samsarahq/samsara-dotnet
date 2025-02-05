using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GoaTagTinyResponseResponseBody
{
    /// <summary>
    /// ID of the tag
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the tag.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// If this tag is part a hierarchical tag tree, this is the ID of the parent tag, otherwise this will be omitted.
    /// </summary>
    [JsonPropertyName("parentTagId")]
    public string? ParentTagId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
