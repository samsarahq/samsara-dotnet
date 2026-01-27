using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReportsDatasetFieldResponseBodyUnit>))]
[Serializable]
public readonly record struct ReportsDatasetFieldResponseBodyUnit : IStringEnum
{
    public static readonly ReportsDatasetFieldResponseBodyUnit Amperes = new(Values.Amperes);

    public static readonly ReportsDatasetFieldResponseBodyUnit Bars = new(Values.Bars);

    public static readonly ReportsDatasetFieldResponseBodyUnit Cad = new(Values.Cad);

    public static readonly ReportsDatasetFieldResponseBodyUnit Chf = new(Values.Chf);

    public static readonly ReportsDatasetFieldResponseBodyUnit Days = new(Values.Days);

    public static readonly ReportsDatasetFieldResponseBodyUnit DecimalDegrees = new(
        Values.DecimalDegrees
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit DegreesCelsius = new(
        Values.DegreesCelsius
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit DegreesFahrenheit = new(
        Values.DegreesFahrenheit
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Eur = new(Values.Eur);

    public static readonly ReportsDatasetFieldResponseBodyUnit Feet = new(Values.Feet);

    public static readonly ReportsDatasetFieldResponseBodyUnit GForces = new(Values.GForces);

    public static readonly ReportsDatasetFieldResponseBodyUnit Gallons = new(Values.Gallons);

    public static readonly ReportsDatasetFieldResponseBodyUnit GallonsPerHour = new(
        Values.GallonsPerHour
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit GallonsPerKilogram = new(
        Values.GallonsPerKilogram
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit GallonsPerMile = new(
        Values.GallonsPerMile
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Gbp = new(Values.Gbp);

    public static readonly ReportsDatasetFieldResponseBodyUnit GramsPerLiter = new(
        Values.GramsPerLiter
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit GramsPerMeter = new(
        Values.GramsPerMeter
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Hertz = new(Values.Hertz);

    public static readonly ReportsDatasetFieldResponseBodyUnit Hours = new(Values.Hours);

    public static readonly ReportsDatasetFieldResponseBodyUnit ImperialGallons = new(
        Values.ImperialGallons
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit ImperialGallonsPerHour = new(
        Values.ImperialGallonsPerHour
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit ImperialGallonsPerKilogram = new(
        Values.ImperialGallonsPerKilogram
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit ImperialGallonsPerMile = new(
        Values.ImperialGallonsPerMile
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Inches = new(Values.Inches);

    public static readonly ReportsDatasetFieldResponseBodyUnit Kelvins = new(Values.Kelvins);

    public static readonly ReportsDatasetFieldResponseBodyUnit Kilograms = new(Values.Kilograms);

    public static readonly ReportsDatasetFieldResponseBodyUnit KilogramsGaseousFuel = new(
        Values.KilogramsGaseousFuel
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit KilogramsPer100KilometerGaseousFuel =
        new(Values.KilogramsPer100KilometerGaseousFuel);

    public static readonly ReportsDatasetFieldResponseBodyUnit KilogramsPerGallon = new(
        Values.KilogramsPerGallon
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit KilogramsPerKilometer = new(
        Values.KilogramsPerKilometer
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit KilogramsPerLiter = new(
        Values.KilogramsPerLiter
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit KilogramsPerMile = new(
        Values.KilogramsPerMile
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Kilometers = new(Values.Kilometers);

    public static readonly ReportsDatasetFieldResponseBodyUnit KilometersPerHour = new(
        Values.KilometersPerHour
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit KilometersPerLiter = new(
        Values.KilometersPerLiter
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit KilometersPerLiterGaseousFuel = new(
        Values.KilometersPerLiterGaseousFuel
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Kilopascals = new(
        Values.Kilopascals
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit KilowattHours = new(
        Values.KilowattHours
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Liters = new(Values.Liters);

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersGaseousFuel = new(
        Values.LitersGaseousFuel
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersPer100Kilometers = new(
        Values.LitersPer100Kilometers
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersPer100KilometersGaseousFuel =
        new(Values.LitersPer100KilometersGaseousFuel);

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersPerHour = new(
        Values.LitersPerHour
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersPerKilogram = new(
        Values.LitersPerKilogram
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersPerKilometer = new(
        Values.LitersPerKilometer
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersPerMeter = new(
        Values.LitersPerMeter
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit LitersPerTonne = new(
        Values.LitersPerTonne
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Meters = new(Values.Meters);

    public static readonly ReportsDatasetFieldResponseBodyUnit MetersPerSecond = new(
        Values.MetersPerSecond
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Miles = new(Values.Miles);

    public static readonly ReportsDatasetFieldResponseBodyUnit MilesPerGallon = new(
        Values.MilesPerGallon
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit MilesPerHour = new(
        Values.MilesPerHour
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit MilesPerImperialGallon = new(
        Values.MilesPerImperialGallon
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit MilesPerKilogramGaseousFuel = new(
        Values.MilesPerKilogramGaseousFuel
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit MilesPerUsGallonGaseousFuel = new(
        Values.MilesPerUsGallonGaseousFuel
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Milliknots = new(Values.Milliknots);

    public static readonly ReportsDatasetFieldResponseBodyUnit Milliseconds = new(
        Values.Milliseconds
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Millivolts = new(Values.Millivolts);

    public static readonly ReportsDatasetFieldResponseBodyUnit Minutes = new(Values.Minutes);

    public static readonly ReportsDatasetFieldResponseBodyUnit Months = new(Values.Months);

    public static readonly ReportsDatasetFieldResponseBodyUnit Mxn = new(Values.Mxn);

    public static readonly ReportsDatasetFieldResponseBodyUnit Percents = new(Values.Percents);

    public static readonly ReportsDatasetFieldResponseBodyUnit Pounds = new(Values.Pounds);

    public static readonly ReportsDatasetFieldResponseBodyUnit PoundsPerGallon = new(
        Values.PoundsPerGallon
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit PoundsPerLiter = new(
        Values.PoundsPerLiter
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit PoundsPerMile = new(
        Values.PoundsPerMile
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit PoundsPerSquareInch = new(
        Values.PoundsPerSquareInch
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit RevolutionsPerMinute = new(
        Values.RevolutionsPerMinute
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Seconds = new(Values.Seconds);

    public static readonly ReportsDatasetFieldResponseBodyUnit Unknown = new(Values.Unknown);

    public static readonly ReportsDatasetFieldResponseBodyUnit UsGallonsGaseousFuel = new(
        Values.UsGallonsGaseousFuel
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Usd = new(Values.Usd);

    public static readonly ReportsDatasetFieldResponseBodyUnit VoltAmperes = new(
        Values.VoltAmperes
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit VoltAmperesReactive = new(
        Values.VoltAmperesReactive
    );

    public static readonly ReportsDatasetFieldResponseBodyUnit Volts = new(Values.Volts);

    public static readonly ReportsDatasetFieldResponseBodyUnit WattHours = new(Values.WattHours);

    public static readonly ReportsDatasetFieldResponseBodyUnit Watts = new(Values.Watts);

    public static readonly ReportsDatasetFieldResponseBodyUnit Weeks = new(Values.Weeks);

    public ReportsDatasetFieldResponseBodyUnit(string value)
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
    public static ReportsDatasetFieldResponseBodyUnit FromCustom(string value)
    {
        return new ReportsDatasetFieldResponseBodyUnit(value);
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

    public static bool operator ==(ReportsDatasetFieldResponseBodyUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReportsDatasetFieldResponseBodyUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReportsDatasetFieldResponseBodyUnit value) =>
        value.Value;

    public static explicit operator ReportsDatasetFieldResponseBodyUnit(string value) => new(value);

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
