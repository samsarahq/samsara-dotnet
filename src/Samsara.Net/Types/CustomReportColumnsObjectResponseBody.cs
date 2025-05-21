using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Information about a custom report column.
/// </summary>
public record CustomReportColumnsObjectResponseBody
{
    /// <summary>
    /// [deprecated] Use unit instead.  Valid values: `bar`, `celsius`, `fahrenheit`, `foot`, `gallon`, `galpermi`, `gforce`, `gperliter`, `gperm`, `impgallon`, `impgalpermi`, `inch`, `kelvin`, `kgpergallon`, `kgperkm`, `kgperliter`, `kgpermi`, `kilogram`, `kilometer`, `kilopascal`, `kilowatthour`, `kmperhr`, `lbpermi`, `liter`, `lper100km`, `lperkm`, `lperm`, `meter`, `meterspersec`, `mile`, `milliknot`, `milliseconds`, `millivolt`, `mipergal`, `miperhr`, `miperimpgal`, `pound`, `poundsPerSquareInch`, `poundspergallon`, `poundsperliter`, `volt`, `watthour`
    /// </summary>
    [JsonPropertyName("baseUnit")]
    public CustomReportColumnsObjectResponseBodyBaseUnit? BaseUnit { get; set; }

    /// <summary>
    /// The display name of the column that appears in the dashboard or exported csv, xlsx, and pdf reports. This value can contain whitespaces and special characters. It is not used to key the values below in the `data` array.
    /// </summary>
    [JsonPropertyName("displayName")]
    public required string DisplayName { get; set; }

    /// <summary>
    /// The type of data for this column.  Valid values: `string`, `numeric`
    /// </summary>
    [JsonPropertyName("type")]
    public required CustomReportColumnsObjectResponseBodyType Type { get; set; }

    /// <summary>
    /// The unit of the data for this column. If the data is a string or custom score (ie, anticipation score), unit will not be returned.  Valid values: `bar`, `degreesCelsius`, `degreesFahrenheit`, `feet`, `gForces`, `gallons`, `gallonsPerMile`, `gramsPerLiter`, `gramsPerMeter`, `imperialGallons`, `imperialGallonsPerMile`, `inches`, `kelvin`, `kilograms`, `kilogramsPerGallon`, `kilogramsPerKilometer`, `kilogramsPerLiter`, `kilogramsPerMile`, `kilometers`, `kilometersPerHour`, `kilopascals`, `kilowattHours`, `liters`, `litersPer100Kilometers`, `litersPerKilometer`, `litersPerMeter`, `meters`, `metersPerSecond`, `miles`, `milesPerGallon`, `milesPerHour`, `milesPerImperialGallon`, `milliknots`, `milliseconds`, `millivolts`, `pounds`, `poundsPerGallon`, `poundsPerLiter`, `poundsPerMile`, `poundsPerSquareInch`, `volts`, `wattHours`
    /// </summary>
    [JsonPropertyName("unit")]
    public CustomReportColumnsObjectResponseBodyUnit? Unit { get; set; }

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
