using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Dictionary containing summarized vehicle report data.
/// </summary>
[Serializable]
public record FuelEnergyVehicleReportDataObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of summarized vehicle reports.
    /// </summary>
    [JsonPropertyName("vehicleReports")]
    public IEnumerable<FuelEnergyVehicleReportObjectResponseBody> VehicleReports { get; set; } =
        new List<FuelEnergyVehicleReportObjectResponseBody>();

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
