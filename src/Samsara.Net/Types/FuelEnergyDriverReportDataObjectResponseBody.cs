using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Dictionary containing summarized driver report data.
/// </summary>
public record FuelEnergyDriverReportDataObjectResponseBody
{
    /// <summary>
    /// List of summarized driver reports.
    /// </summary>
    [JsonPropertyName("driverReports")]
    public IEnumerable<FuelEnergyDriverReportObjectResponseBody> DriverReports { get; set; } =
        new List<FuelEnergyDriverReportObjectResponseBody>();

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
