using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record GetCustomReportRunDataObjectResponseBody
{
    /// <summary>
    /// An array of objects containing data about column definitions
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<CustomReportColumnsObjectResponseBody>? Columns { get; set; }

    /// <summary>
    /// An array of arrays that represents each row in a custom report. The first index represents which row the data is for and the second index represents which column the data is for. For example, rows[1][3] accesses the second row's fourth column data.
    /// </summary>
    [JsonPropertyName("rows")]
    public IEnumerable<IEnumerable<object>> Rows { get; set; } = new List<IEnumerable<object>>();

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
