using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FuelEnergyVehicleReportObjectResponseBody
{
    /// <summary>
    /// Meters traveled over the given time range.
    /// </summary>
    [JsonPropertyName("distanceTraveledMeters")]
    public required double DistanceTraveledMeters { get; set; }

    /// <summary>
    /// Efficiency in MPG or MPGE over the given time range. For fuel vehicles this will be provided in MPG, for hybrid and electric vehicles this will be provided in MPGE. MPG/MPGE values are provided based on US gallons.
    /// </summary>
    [JsonPropertyName("efficiencyMpge")]
    public required double EfficiencyMpge { get; set; }

    /// <summary>
    /// Kilowatt-hours of energy used over the given time range. Only provided for hybrid and electric vehicles.
    /// </summary>
    [JsonPropertyName("energyUsedKwh")]
    public double? EnergyUsedKwh { get; set; }

    /// <summary>
    /// Milliseconds of engine idle time over the given time range. Only provided for fuel and hybrid vehicles.
    /// </summary>
    [JsonPropertyName("engineIdleTimeDurationMs")]
    public long? EngineIdleTimeDurationMs { get; set; }

    /// <summary>
    /// Milliseconds of engine run time over the given time range. Only provided for fuel and hybrid vehicles.
    /// </summary>
    [JsonPropertyName("engineRunTimeDurationMs")]
    public long? EngineRunTimeDurationMs { get; set; }

    /// <summary>
    /// Estimated kilograms of carbon emissions over the given time range. Only provided for fuel and hybrid vehicles.
    /// </summary>
    [JsonPropertyName("estCarbonEmissionsKg")]
    public double? EstCarbonEmissionsKg { get; set; }

    [JsonPropertyName("estFuelEnergyCost")]
    public required FuelEnergyCostResponseResponseBody EstFuelEnergyCost { get; set; }

    /// <summary>
    /// Milliliters of fuel consumed over the given time range. Only provided for fuel and hybrid vehicles.
    /// </summary>
    [JsonPropertyName("fuelConsumedMl")]
    public double? FuelConsumedMl { get; set; }

    [JsonPropertyName("vehicle")]
    public required FuelEnergyVehicleObjectResponseBody Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
