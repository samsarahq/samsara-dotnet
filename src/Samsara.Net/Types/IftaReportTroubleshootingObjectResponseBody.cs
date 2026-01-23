using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// IFTA report troubleshooting information.
/// </summary>
[Serializable]
public record IftaReportTroubleshootingObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether or not fuel purchases were found for this report.
    /// </summary>
    [JsonPropertyName("noPurchasesFound")]
    public required bool NoPurchasesFound { get; set; }

    /// <summary>
    /// The number of fuel purchases without a fuel type assigned. Fuel purchases are used to calculate tax paid gallons.
    /// </summary>
    [JsonPropertyName("unassignedFuelTypePurchases")]
    public required long UnassignedFuelTypePurchases { get; set; }

    /// <summary>
    /// The number of vehicles without a fuel type assigned. Vehicles without an assigned fuel type may affect total mileage.
    /// </summary>
    [JsonPropertyName("unassignedFuelTypeVehicles")]
    public required long UnassignedFuelTypeVehicles { get; set; }

    /// <summary>
    /// Purchases without an assigned fuel type may affect tax-paid gallons and fleet mpg.
    /// </summary>
    [JsonPropertyName("unassignedVehiclePurchases")]
    public required long UnassignedVehiclePurchases { get; set; }

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
