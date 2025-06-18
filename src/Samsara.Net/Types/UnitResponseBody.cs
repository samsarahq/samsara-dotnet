using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Unit information
/// </summary>
public record UnitResponseBody
{
    /// <summary>
    /// Unit of measurement  Valid values: `bar`, `celsius`, `fahrenheit`, `foot`, `gallon`, `galpermi`, `gforce`, `gperliter`, `gperm`, `hour`, `impgallon`, `impgalpermi`, `inch`, `kelvin`, `kgper100kmgaseousfuel`, `kgpergallon`, `kgperkm`, `kgperliter`, `kgpermi`, `kilogram`, `kilogramgaseousfuel`, `kilometer`, `kilopascal`, `kilowatthour`, `kmperhr`, `lbpermi`, `liter`, `litergaseousfuel`, `lper100km`, `lper100kmgaseousfuel`, `lperkm`, `lperm`, `meter`, `meterspersec`, `mile`, `milliknot`, `millisecond`, `millivolt`, `mipergal`, `miperhr`, `miperimpgal`, `mpgusgalgaseousfuel`, `mpkggaseousfuel`, `percent`, `pound`, `poundsPerSquareInch`, `poundspergallon`, `poundsperliter`, `second`, `usd`, `usgallongaseousfuel`, `volt`, `watthour`
    /// </summary>
    [JsonPropertyName("baseUnit")]
    public UnitResponseBodyBaseUnit? BaseUnit { get; set; }

    /// <summary>
    /// Type of measurement  Valid values: `acceleration`, `co2EmissionsPerVolumeRate`, `currency`, `distance`, `drySpreadRate`, `duration`, `energy`, `fuelEconomy`, `gaseousFuel`, `gaseousFuelEconomy`, `pressure`, `ratio`, `speed`, `temperature`, `time`, `voltage`, `volume`, `weight`, `wetSpreadRate`
    /// </summary>
    [JsonPropertyName("measurementType")]
    public UnitResponseBodyMeasurementType? MeasurementType { get; set; }

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
