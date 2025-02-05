using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
