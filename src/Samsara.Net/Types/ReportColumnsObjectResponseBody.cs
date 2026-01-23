using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record ReportColumnsObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Data type of the column.  Valid values: `string`, `float`, `integer`, `timestamp`, `unknown`
    /// </summary>
    [JsonPropertyName("dataType")]
    public required ReportColumnsObjectResponseBodyDataType DataType { get; set; }

    /// <summary>
    /// Name of the column.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Unit of the column.  Valid values: `amperes`, `bars`, `cad`, `chf`, `days`, `decimalDegrees`, `degreesCelsius`, `degreesFahrenheit`, `eur`, `feet`, `gForces`, `gallons`, `gallonsPerHour`, `gallonsPerKilogram`, `gallonsPerMile`, `gbp`, `gramsPerLiter`, `gramsPerMeter`, `hertz`, `hours`, `imperialGallons`, `imperialGallonsPerHour`, `imperialGallonsPerKilogram`, `imperialGallonsPerMile`, `inches`, `kelvins`, `kilograms`, `kilogramsGaseousFuel`, `kilogramsPer100KilometerGaseousFuel`, `kilogramsPerGallon`, `kilogramsPerKilometer`, `kilogramsPerLiter`, `kilogramsPerMile`, `kilometers`, `kilometersPerHour`, `kilometersPerLiter`, `kilometersPerLiterGaseousFuel`, `kilopascals`, `kilowattHours`, `liters`, `litersGaseousFuel`, `litersPer100Kilometers`, `litersPer100KilometersGaseousFuel`, `litersPerHour`, `litersPerKilogram`, `litersPerKilometer`, `litersPerMeter`, `litersPerTonne`, `meters`, `metersPerSecond`, `miles`, `milesPerGallon`, `milesPerHour`, `milesPerImperialGallon`, `milesPerKilogramGaseousFuel`, `milesPerUSGallonGaseousFuel`, `milliknots`, `milliseconds`, `millivolts`, `minutes`, `months`, `mxn`, `percents`, `pounds`, `poundsPerGallon`, `poundsPerLiter`, `poundsPerMile`, `poundsPerSquareInch`, `revolutionsPerMinute`, `seconds`, `unknown`, `usGallonsGaseousFuel`, `usd`, `voltAmperes`, `voltAmperesReactive`, `volts`, `wattHours`, `watts`, `weeks`
    /// </summary>
    [JsonPropertyName("unit")]
    public ReportColumnsObjectResponseBodyUnit? Unit { get; set; }

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
