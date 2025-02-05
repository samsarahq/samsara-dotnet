using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<CustomReportColumnsObjectResponseBodyUnit>))]
public enum CustomReportColumnsObjectResponseBodyUnit
{
    [EnumMember(Value = "bar")]
    Bar,

    [EnumMember(Value = "degreesCelsius")]
    DegreesCelsius,

    [EnumMember(Value = "degreesFahrenheit")]
    DegreesFahrenheit,

    [EnumMember(Value = "feet")]
    Feet,

    [EnumMember(Value = "gForces")]
    GForces,

    [EnumMember(Value = "gallons")]
    Gallons,

    [EnumMember(Value = "gallonsPerMile")]
    GallonsPerMile,

    [EnumMember(Value = "gramsPerLiter")]
    GramsPerLiter,

    [EnumMember(Value = "gramsPerMeter")]
    GramsPerMeter,

    [EnumMember(Value = "imperialGallons")]
    ImperialGallons,

    [EnumMember(Value = "imperialGallonsPerMile")]
    ImperialGallonsPerMile,

    [EnumMember(Value = "inches")]
    Inches,

    [EnumMember(Value = "kelvin")]
    Kelvin,

    [EnumMember(Value = "kilograms")]
    Kilograms,

    [EnumMember(Value = "kilogramsPerGallon")]
    KilogramsPerGallon,

    [EnumMember(Value = "kilogramsPerKilometer")]
    KilogramsPerKilometer,

    [EnumMember(Value = "kilogramsPerLiter")]
    KilogramsPerLiter,

    [EnumMember(Value = "kilogramsPerMile")]
    KilogramsPerMile,

    [EnumMember(Value = "kilometers")]
    Kilometers,

    [EnumMember(Value = "kilometersPerHour")]
    KilometersPerHour,

    [EnumMember(Value = "kilopascals")]
    Kilopascals,

    [EnumMember(Value = "kilowattHours")]
    KilowattHours,

    [EnumMember(Value = "liters")]
    Liters,

    [EnumMember(Value = "litersPer100Kilometers")]
    LitersPer100Kilometers,

    [EnumMember(Value = "litersPerKilometer")]
    LitersPerKilometer,

    [EnumMember(Value = "litersPerMeter")]
    LitersPerMeter,

    [EnumMember(Value = "meters")]
    Meters,

    [EnumMember(Value = "metersPerSecond")]
    MetersPerSecond,

    [EnumMember(Value = "miles")]
    Miles,

    [EnumMember(Value = "milesPerGallon")]
    MilesPerGallon,

    [EnumMember(Value = "milesPerHour")]
    MilesPerHour,

    [EnumMember(Value = "milesPerImperialGallon")]
    MilesPerImperialGallon,

    [EnumMember(Value = "milliknots")]
    Milliknots,

    [EnumMember(Value = "milliseconds")]
    Milliseconds,

    [EnumMember(Value = "millivolts")]
    Millivolts,

    [EnumMember(Value = "pounds")]
    Pounds,

    [EnumMember(Value = "poundsPerGallon")]
    PoundsPerGallon,

    [EnumMember(Value = "poundsPerLiter")]
    PoundsPerLiter,

    [EnumMember(Value = "poundsPerMile")]
    PoundsPerMile,

    [EnumMember(Value = "poundsPerSquareInch")]
    PoundsPerSquareInch,

    [EnumMember(Value = "volts")]
    Volts,

    [EnumMember(Value = "wattHours")]
    WattHours,
}
