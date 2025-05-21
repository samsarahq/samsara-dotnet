using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Full Custom report config object
/// </summary>
public record CustomReportConfigObjectResponseBody
{
    /// <summary>
    /// List of custom report column objects
    /// </summary>
    [JsonPropertyName("columns")]
    public IEnumerable<CustomReportColumnsObjectResponseBody> Columns { get; set; } =
        new List<CustomReportColumnsObjectResponseBody>();

    /// <summary>
    /// ID of the custom report config.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the custom report config.
    /// </summary>
    [JsonPropertyName("reportName")]
    public required string ReportName { get; set; }

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
