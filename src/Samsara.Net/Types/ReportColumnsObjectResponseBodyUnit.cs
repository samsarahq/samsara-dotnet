using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReportColumnsObjectResponseBodyUnit>))]
[Serializable]
public readonly record struct ReportColumnsObjectResponseBodyUnit : IStringEnum
{
    public static readonly ReportColumnsObjectResponseBodyUnit Amperes = new(Values.Amperes);

    public static readonly ReportColumnsObjectResponseBodyUnit Bars = new(Values.Bars);

    public static readonly ReportColumnsObjectResponseBodyUnit Cad = new(Values.Cad);

    public static readonly ReportColumnsObjectResponseBodyUnit Chf = new(Values.Chf);

    public static readonly ReportColumnsObjectResponseBodyUnit Days = new(Values.Days);

    public static readonly ReportColumnsObjectResponseBodyUnit DecimalDegrees = new(
        Values.DecimalDegrees
    );

    public static readonly ReportColumnsObjectResponseBodyUnit DegreesCelsius = new(
        Values.DegreesCelsius
    );

    public static readonly ReportColumnsObjectResponseBodyUnit DegreesFahrenheit = new(
        Values.DegreesFahrenheit
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Eur = new(Values.Eur);

    public static readonly ReportColumnsObjectResponseBodyUnit Feet = new(Values.Feet);

    public static readonly ReportColumnsObjectResponseBodyUnit GForces = new(Values.GForces);

    public static readonly ReportColumnsObjectResponseBodyUnit Gallons = new(Values.Gallons);

    public static readonly ReportColumnsObjectResponseBodyUnit GallonsPerHour = new(
        Values.GallonsPerHour
    );

    public static readonly ReportColumnsObjectResponseBodyUnit GallonsPerKilogram = new(
        Values.GallonsPerKilogram
    );

    public static readonly ReportColumnsObjectResponseBodyUnit GallonsPerMile = new(
        Values.GallonsPerMile
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Gbp = new(Values.Gbp);

    public static readonly ReportColumnsObjectResponseBodyUnit GramsPerLiter = new(
        Values.GramsPerLiter
    );

    public static readonly ReportColumnsObjectResponseBodyUnit GramsPerMeter = new(
        Values.GramsPerMeter
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Hertz = new(Values.Hertz);

    public static readonly ReportColumnsObjectResponseBodyUnit Hours = new(Values.Hours);

    public static readonly ReportColumnsObjectResponseBodyUnit ImperialGallons = new(
        Values.ImperialGallons
    );

    public static readonly ReportColumnsObjectResponseBodyUnit ImperialGallonsPerHour = new(
        Values.ImperialGallonsPerHour
    );

    public static readonly ReportColumnsObjectResponseBodyUnit ImperialGallonsPerKilogram = new(
        Values.ImperialGallonsPerKilogram
    );

    public static readonly ReportColumnsObjectResponseBodyUnit ImperialGallonsPerMile = new(
        Values.ImperialGallonsPerMile
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Inches = new(Values.Inches);

    public static readonly ReportColumnsObjectResponseBodyUnit Kelvins = new(Values.Kelvins);

    public static readonly ReportColumnsObjectResponseBodyUnit Kilograms = new(Values.Kilograms);

    public static readonly ReportColumnsObjectResponseBodyUnit KilogramsGaseousFuel = new(
        Values.KilogramsGaseousFuel
    );

    public static readonly ReportColumnsObjectResponseBodyUnit KilogramsPer100KilometerGaseousFuel =
        new(Values.KilogramsPer100KilometerGaseousFuel);

    public static readonly ReportColumnsObjectResponseBodyUnit KilogramsPerGallon = new(
        Values.KilogramsPerGallon
    );

    public static readonly ReportColumnsObjectResponseBodyUnit KilogramsPerKilometer = new(
        Values.KilogramsPerKilometer
    );

    public static readonly ReportColumnsObjectResponseBodyUnit KilogramsPerLiter = new(
        Values.KilogramsPerLiter
    );

    public static readonly ReportColumnsObjectResponseBodyUnit KilogramsPerMile = new(
        Values.KilogramsPerMile
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Kilometers = new(Values.Kilometers);

    public static readonly ReportColumnsObjectResponseBodyUnit KilometersPerHour = new(
        Values.KilometersPerHour
    );

    public static readonly ReportColumnsObjectResponseBodyUnit KilometersPerLiter = new(
        Values.KilometersPerLiter
    );

    public static readonly ReportColumnsObjectResponseBodyUnit KilometersPerLiterGaseousFuel = new(
        Values.KilometersPerLiterGaseousFuel
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Kilopascals = new(
        Values.Kilopascals
    );

    public static readonly ReportColumnsObjectResponseBodyUnit KilowattHours = new(
        Values.KilowattHours
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Liters = new(Values.Liters);

    public static readonly ReportColumnsObjectResponseBodyUnit LitersGaseousFuel = new(
        Values.LitersGaseousFuel
    );

    public static readonly ReportColumnsObjectResponseBodyUnit LitersPer100Kilometers = new(
        Values.LitersPer100Kilometers
    );

    public static readonly ReportColumnsObjectResponseBodyUnit LitersPer100KilometersGaseousFuel =
        new(Values.LitersPer100KilometersGaseousFuel);

    public static readonly ReportColumnsObjectResponseBodyUnit LitersPerHour = new(
        Values.LitersPerHour
    );

    public static readonly ReportColumnsObjectResponseBodyUnit LitersPerKilogram = new(
        Values.LitersPerKilogram
    );

    public static readonly ReportColumnsObjectResponseBodyUnit LitersPerKilometer = new(
        Values.LitersPerKilometer
    );

    public static readonly ReportColumnsObjectResponseBodyUnit LitersPerMeter = new(
        Values.LitersPerMeter
    );

    public static readonly ReportColumnsObjectResponseBodyUnit LitersPerTonne = new(
        Values.LitersPerTonne
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Meters = new(Values.Meters);

    public static readonly ReportColumnsObjectResponseBodyUnit MetersPerSecond = new(
        Values.MetersPerSecond
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Miles = new(Values.Miles);

    public static readonly ReportColumnsObjectResponseBodyUnit MilesPerGallon = new(
        Values.MilesPerGallon
    );

    public static readonly ReportColumnsObjectResponseBodyUnit MilesPerHour = new(
        Values.MilesPerHour
    );

    public static readonly ReportColumnsObjectResponseBodyUnit MilesPerImperialGallon = new(
        Values.MilesPerImperialGallon
    );

    public static readonly ReportColumnsObjectResponseBodyUnit MilesPerKilogramGaseousFuel = new(
        Values.MilesPerKilogramGaseousFuel
    );

    public static readonly ReportColumnsObjectResponseBodyUnit MilesPerUsGallonGaseousFuel = new(
        Values.MilesPerUsGallonGaseousFuel
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Milliknots = new(Values.Milliknots);

    public static readonly ReportColumnsObjectResponseBodyUnit Milliseconds = new(
        Values.Milliseconds
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Millivolts = new(Values.Millivolts);

    public static readonly ReportColumnsObjectResponseBodyUnit Minutes = new(Values.Minutes);

    public static readonly ReportColumnsObjectResponseBodyUnit Months = new(Values.Months);

    public static readonly ReportColumnsObjectResponseBodyUnit Mxn = new(Values.Mxn);

    public static readonly ReportColumnsObjectResponseBodyUnit Percents = new(Values.Percents);

    public static readonly ReportColumnsObjectResponseBodyUnit Pounds = new(Values.Pounds);

    public static readonly ReportColumnsObjectResponseBodyUnit PoundsPerGallon = new(
        Values.PoundsPerGallon
    );

    public static readonly ReportColumnsObjectResponseBodyUnit PoundsPerLiter = new(
        Values.PoundsPerLiter
    );

    public static readonly ReportColumnsObjectResponseBodyUnit PoundsPerMile = new(
        Values.PoundsPerMile
    );

    public static readonly ReportColumnsObjectResponseBodyUnit PoundsPerSquareInch = new(
        Values.PoundsPerSquareInch
    );

    public static readonly ReportColumnsObjectResponseBodyUnit RevolutionsPerMinute = new(
        Values.RevolutionsPerMinute
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Seconds = new(Values.Seconds);

    public static readonly ReportColumnsObjectResponseBodyUnit Unknown = new(Values.Unknown);

    public static readonly ReportColumnsObjectResponseBodyUnit UsGallonsGaseousFuel = new(
        Values.UsGallonsGaseousFuel
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Usd = new(Values.Usd);

    public static readonly ReportColumnsObjectResponseBodyUnit VoltAmperes = new(
        Values.VoltAmperes
    );

    public static readonly ReportColumnsObjectResponseBodyUnit VoltAmperesReactive = new(
        Values.VoltAmperesReactive
    );

    public static readonly ReportColumnsObjectResponseBodyUnit Volts = new(Values.Volts);

    public static readonly ReportColumnsObjectResponseBodyUnit WattHours = new(Values.WattHours);

    public static readonly ReportColumnsObjectResponseBodyUnit Watts = new(Values.Watts);

    public static readonly ReportColumnsObjectResponseBodyUnit Weeks = new(Values.Weeks);

    public ReportColumnsObjectResponseBodyUnit(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static ReportColumnsObjectResponseBodyUnit FromCustom(string value)
    {
        return new ReportColumnsObjectResponseBodyUnit(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(ReportColumnsObjectResponseBodyUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportColumnsObjectResponseBodyUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportColumnsObjectResponseBodyUnit value) =>
        value.Value;

    public static explicit operator ReportColumnsObjectResponseBodyUnit(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Amperes = "amperes";

        public const string Bars = "bars";

        public const string Cad = "cad";

        public const string Chf = "chf";

        public const string Days = "days";

        public const string DecimalDegrees = "decimalDegrees";

        public const string DegreesCelsius = "degreesCelsius";

        public const string DegreesFahrenheit = "degreesFahrenheit";

        public const string Eur = "eur";

        public const string Feet = "feet";

        public const string GForces = "gForces";

        public const string Gallons = "gallons";

        public const string GallonsPerHour = "gallonsPerHour";

        public const string GallonsPerKilogram = "gallonsPerKilogram";

        public const string GallonsPerMile = "gallonsPerMile";

        public const string Gbp = "gbp";

        public const string GramsPerLiter = "gramsPerLiter";

        public const string GramsPerMeter = "gramsPerMeter";

        public const string Hertz = "hertz";

        public const string Hours = "hours";

        public const string ImperialGallons = "imperialGallons";

        public const string ImperialGallonsPerHour = "imperialGallonsPerHour";

        public const string ImperialGallonsPerKilogram = "imperialGallonsPerKilogram";

        public const string ImperialGallonsPerMile = "imperialGallonsPerMile";

        public const string Inches = "inches";

        public const string Kelvins = "kelvins";

        public const string Kilograms = "kilograms";

        public const string KilogramsGaseousFuel = "kilogramsGaseousFuel";

        public const string KilogramsPer100KilometerGaseousFuel =
            "kilogramsPer100KilometerGaseousFuel";

        public const string KilogramsPerGallon = "kilogramsPerGallon";

        public const string KilogramsPerKilometer = "kilogramsPerKilometer";

        public const string KilogramsPerLiter = "kilogramsPerLiter";

        public const string KilogramsPerMile = "kilogramsPerMile";

        public const string Kilometers = "kilometers";

        public const string KilometersPerHour = "kilometersPerHour";

        public const string KilometersPerLiter = "kilometersPerLiter";

        public const string KilometersPerLiterGaseousFuel = "kilometersPerLiterGaseousFuel";

        public const string Kilopascals = "kilopascals";

        public const string KilowattHours = "kilowattHours";

        public const string Liters = "liters";

        public const string LitersGaseousFuel = "litersGaseousFuel";

        public const string LitersPer100Kilometers = "litersPer100Kilometers";

        public const string LitersPer100KilometersGaseousFuel = "litersPer100KilometersGaseousFuel";

        public const string LitersPerHour = "litersPerHour";

        public const string LitersPerKilogram = "litersPerKilogram";

        public const string LitersPerKilometer = "litersPerKilometer";

        public const string LitersPerMeter = "litersPerMeter";

        public const string LitersPerTonne = "litersPerTonne";

        public const string Meters = "meters";

        public const string MetersPerSecond = "metersPerSecond";

        public const string Miles = "miles";

        public const string MilesPerGallon = "milesPerGallon";

        public const string MilesPerHour = "milesPerHour";

        public const string MilesPerImperialGallon = "milesPerImperialGallon";

        public const string MilesPerKilogramGaseousFuel = "milesPerKilogramGaseousFuel";

        public const string MilesPerUsGallonGaseousFuel = "milesPerUSGallonGaseousFuel";

        public const string Milliknots = "milliknots";

        public const string Milliseconds = "milliseconds";

        public const string Millivolts = "millivolts";

        public const string Minutes = "minutes";

        public const string Months = "months";

        public const string Mxn = "mxn";

        public const string Percents = "percents";

        public const string Pounds = "pounds";

        public const string PoundsPerGallon = "poundsPerGallon";

        public const string PoundsPerLiter = "poundsPerLiter";

        public const string PoundsPerMile = "poundsPerMile";

        public const string PoundsPerSquareInch = "poundsPerSquareInch";

        public const string RevolutionsPerMinute = "revolutionsPerMinute";

        public const string Seconds = "seconds";

        public const string Unknown = "unknown";

        public const string UsGallonsGaseousFuel = "usGallonsGaseousFuel";

        public const string Usd = "usd";

        public const string VoltAmperes = "voltAmperes";

        public const string VoltAmperesReactive = "voltAmperesReactive";

        public const string Volts = "volts";

        public const string WattHours = "wattHours";

        public const string Watts = "watts";

        public const string Weeks = "weeks";
    }
}
