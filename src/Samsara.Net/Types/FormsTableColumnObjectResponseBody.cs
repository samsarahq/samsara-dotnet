using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Defines a column in a table form input field.
/// </summary>
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
    public string Type { get; set; } =
        "text, number, datetime, check_boxes, multiple_choice, signature, media, person";

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
