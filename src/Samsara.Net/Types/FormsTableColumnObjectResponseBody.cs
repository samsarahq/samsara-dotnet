using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsTableColumnObjectResponseBody
{
    /// <summary>
    /// Unique identifier for the column.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Label of the column.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// Type of the column field.  Valid values: `text, number, datetime, check_boxes, multiple_choice, signature, media, person`
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
