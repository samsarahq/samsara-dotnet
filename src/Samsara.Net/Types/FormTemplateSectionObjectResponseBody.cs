using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormTemplateSectionObjectResponseBody
{
    /// <summary>
    /// The index of the first field from the fields array that is in this section. Index 0 represents the first field definition of the fields array.
    /// </summary>
    [JsonPropertyName("fieldIndexFirstInclusive")]
    public required long FieldIndexFirstInclusive { get; set; }

    /// <summary>
    /// The index of the last field from the fields array that is in this section.
    /// </summary>
    [JsonPropertyName("fieldIndexLastInclusive")]
    public required long FieldIndexLastInclusive { get; set; }

    /// <summary>
    /// Label of the section.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
