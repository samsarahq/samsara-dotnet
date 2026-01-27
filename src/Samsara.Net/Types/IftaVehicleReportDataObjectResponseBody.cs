using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Dictionary containing summarized vehicle report data.
/// </summary>
[Serializable]
public record IftaVehicleReportDataObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The specified month duration for this IFTA report.
    /// </summary>
    [JsonPropertyName("month")]
    public string? Month { get; set; }

    /// <summary>
    /// The specified quarter duration for this IFTA report.
    /// </summary>
    [JsonPropertyName("quarter")]
    public string? Quarter { get; set; }

    [JsonPropertyName("troubleshooting")]
    public IftaReportTroubleshootingObjectResponseBody? Troubleshooting { get; set; }

    /// <summary>
    /// List of summarized vehicle reports.
    /// </summary>
    [JsonPropertyName("vehicleReports")]
    public IEnumerable<IftaVehicleReportObjectResponseBody> VehicleReports { get; set; } =
        new List<IftaVehicleReportObjectResponseBody>();

    /// <summary>
    /// The specified year for this IFTA report.
    /// </summary>
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
