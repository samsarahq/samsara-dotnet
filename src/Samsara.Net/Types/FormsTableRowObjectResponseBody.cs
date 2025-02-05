using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsTableRowObjectResponseBody
{
    /// <summary>
    /// List of cells in the row.
    /// </summary>
    [JsonPropertyName("cells")]
    public IEnumerable<FormsTableCellObjectResponseBody> Cells { get; set; } =
        new List<FormsTableCellObjectResponseBody>();

    /// <summary>
    /// Unique identifier for the row.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
