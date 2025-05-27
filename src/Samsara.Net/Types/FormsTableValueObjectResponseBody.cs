using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The value of a table form input field.
/// </summary>
public record FormsTableValueObjectResponseBody
{
    /// <summary>
    /// List of table columns.
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<FormsTableColumnObjectResponseBody> Columns { get; set; } =
        new List<FormsTableColumnObjectResponseBody>();

    /// <summary>
    /// List of table rows.
    /// </summary>
    [JsonPropertyName("rows")]
    public IEnumerable<FormsTableRowObjectResponseBody> Rows { get; set; } =
        new List<FormsTableRowObjectResponseBody>();

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
