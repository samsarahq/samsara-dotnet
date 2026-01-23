using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ColumnResponseBodyUnit>))]
[Serializable]
public readonly record struct ColumnResponseBodyUnit : IStringEnum
{
    public static readonly ColumnResponseBodyUnit Amperes = new(Values.Amperes);

    public static readonly ColumnResponseBodyUnit Bars = new(Values.Bars);

    public static readonly ColumnResponseBodyUnit Cad = new(Values.Cad);

    public static readonly ColumnResponseBodyUnit Chf = new(Values.Chf);

    public static readonly ColumnResponseBodyUnit Days = new(Values.Days);

    public static readonly ColumnResponseBodyUnit DecimalDegrees = new(Values.DecimalDegrees);

    public static readonly ColumnResponseBodyUnit DegreesCelsius = new(Values.DegreesCelsius);

    public static readonly ColumnResponseBodyUnit DegreesFahrenheit = new(Values.DegreesFahrenheit);

    public static readonly ColumnResponseBodyUnit Eur = new(Values.Eur);

    public static readonly ColumnResponseBodyUnit Feet = new(Values.Feet);

    public static readonly ColumnResponseBodyUnit GForces = new(Values.GForces);

    public static readonly ColumnResponseBodyUnit Gallons = new(Values.Gallons);

    public static readonly ColumnResponseBodyUnit GallonsPerHour = new(Values.GallonsPerHour);

    public static readonly ColumnResponseBodyUnit GallonsPerKilogram = new(
        Values.GallonsPerKilogram
    );

    public static readonly ColumnResponseBodyUnit GallonsPerMile = new(Values.GallonsPerMile);

    public static readonly ColumnResponseBodyUnit Gbp = new(Values.Gbp);

    public static readonly ColumnResponseBodyUnit GramsPerLiter = new(Values.GramsPerLiter);

    public static readonly ColumnResponseBodyUnit GramsPerMeter = new(Values.GramsPerMeter);

    public static readonly ColumnResponseBodyUnit Hertz = new(Values.Hertz);

    public static readonly ColumnResponseBodyUnit Hours = new(Values.Hours);

    public static readonly ColumnResponseBodyUnit ImperialGallons = new(Values.ImperialGallons);

    public static readonly ColumnResponseBodyUnit ImperialGallonsPerHour = new(
        Values.ImperialGallonsPerHour
    );

    public static readonly ColumnResponseBodyUnit ImperialGallonsPerKilogram = new(
        Values.ImperialGallonsPerKilogram
    );

    public static readonly ColumnResponseBodyUnit ImperialGallonsPerMile = new(
        Values.ImperialGallonsPerMile
    );

    public static readonly ColumnResponseBodyUnit Inches = new(Values.Inches);

    public static readonly ColumnResponseBodyUnit Kelvins = new(Values.Kelvins);

    public static readonly ColumnResponseBodyUnit Kilograms = new(Values.Kilograms);

    public static readonly ColumnResponseBodyUnit KilogramsGaseousFuel = new(
        Values.KilogramsGaseousFuel
    );

    public static readonly ColumnResponseBodyUnit KilogramsPer100KilometerGaseousFuel = new(
        Values.KilogramsPer100KilometerGaseousFuel
    );

    public static readonly ColumnResponseBodyUnit KilogramsPerGallon = new(
        Values.KilogramsPerGallon
    );

    public static readonly ColumnResponseBodyUnit KilogramsPerKilometer = new(
        Values.KilogramsPerKilometer
    );

    public static readonly ColumnResponseBodyUnit KilogramsPerLiter = new(Values.KilogramsPerLiter);

    public static readonly ColumnResponseBodyUnit KilogramsPerMile = new(Values.KilogramsPerMile);

    public static readonly ColumnResponseBodyUnit Kilometers = new(Values.Kilometers);

    public static readonly ColumnResponseBodyUnit KilometersPerHour = new(Values.KilometersPerHour);

    public static readonly ColumnResponseBodyUnit KilometersPerLiter = new(
        Values.KilometersPerLiter
    );

    public static readonly ColumnResponseBodyUnit KilometersPerLiterGaseousFuel = new(
        Values.KilometersPerLiterGaseousFuel
    );

    public static readonly ColumnResponseBodyUnit Kilopascals = new(Values.Kilopascals);

    public static readonly ColumnResponseBodyUnit KilowattHours = new(Values.KilowattHours);

    public static readonly ColumnResponseBodyUnit Liters = new(Values.Liters);

    public static readonly ColumnResponseBodyUnit LitersGaseousFuel = new(Values.LitersGaseousFuel);

    public static readonly ColumnResponseBodyUnit LitersPer100Kilometers = new(
        Values.LitersPer100Kilometers
    );

    public static readonly ColumnResponseBodyUnit LitersPer100KilometersGaseousFuel = new(
        Values.LitersPer100KilometersGaseousFuel
    );

    public static readonly ColumnResponseBodyUnit LitersPerHour = new(Values.LitersPerHour);

    public static readonly ColumnResponseBodyUnit LitersPerKilogram = new(Values.LitersPerKilogram);

    public static readonly ColumnResponseBodyUnit LitersPerKilometer = new(
        Values.LitersPerKilometer
    );

    public static readonly ColumnResponseBodyUnit LitersPerMeter = new(Values.LitersPerMeter);

    public static readonly ColumnResponseBodyUnit LitersPerTonne = new(Values.LitersPerTonne);

    public static readonly ColumnResponseBodyUnit Meters = new(Values.Meters);

    public static readonly ColumnResponseBodyUnit MetersPerSecond = new(Values.MetersPerSecond);

    public static readonly ColumnResponseBodyUnit Miles = new(Values.Miles);

    public static readonly ColumnResponseBodyUnit MilesPerGallon = new(Values.MilesPerGallon);

    public static readonly ColumnResponseBodyUnit MilesPerHour = new(Values.MilesPerHour);

    public static readonly ColumnResponseBodyUnit MilesPerImperialGallon = new(
        Values.MilesPerImperialGallon
    );

    public static readonly ColumnResponseBodyUnit MilesPerKilogramGaseousFuel = new(
        Values.MilesPerKilogramGaseousFuel
    );

    public static readonly ColumnResponseBodyUnit MilesPerUsGallonGaseousFuel = new(
        Values.MilesPerUsGallonGaseousFuel
    );

    public static readonly ColumnResponseBodyUnit Milliknots = new(Values.Milliknots);

    public static readonly ColumnResponseBodyUnit Milliseconds = new(Values.Milliseconds);

    public static readonly ColumnResponseBodyUnit Millivolts = new(Values.Millivolts);

    public static readonly ColumnResponseBodyUnit Minutes = new(Values.Minutes);

    public static readonly ColumnResponseBodyUnit Months = new(Values.Months);

    public static readonly ColumnResponseBodyUnit Mxn = new(Values.Mxn);

    public static readonly ColumnResponseBodyUnit Percents = new(Values.Percents);

    public static readonly ColumnResponseBodyUnit Pounds = new(Values.Pounds);

    public static readonly ColumnResponseBodyUnit PoundsPerGallon = new(Values.PoundsPerGallon);

    public static readonly ColumnResponseBodyUnit PoundsPerLiter = new(Values.PoundsPerLiter);

    public static readonly ColumnResponseBodyUnit PoundsPerMile = new(Values.PoundsPerMile);

    public static readonly ColumnResponseBodyUnit PoundsPerSquareInch = new(
        Values.PoundsPerSquareInch
    );

    public static readonly ColumnResponseBodyUnit RevolutionsPerMinute = new(
        Values.RevolutionsPerMinute
    );

    public static readonly ColumnResponseBodyUnit Seconds = new(Values.Seconds);

    public static readonly ColumnResponseBodyUnit Unknown = new(Values.Unknown);

    public static readonly ColumnResponseBodyUnit UsGallonsGaseousFuel = new(
        Values.UsGallonsGaseousFuel
    );

    public static readonly ColumnResponseBodyUnit Usd = new(Values.Usd);

    public static readonly ColumnResponseBodyUnit VoltAmperes = new(Values.VoltAmperes);

    public static readonly ColumnResponseBodyUnit VoltAmperesReactive = new(
        Values.VoltAmperesReactive
    );

    public static readonly ColumnResponseBodyUnit Volts = new(Values.Volts);

    public static readonly ColumnResponseBodyUnit WattHours = new(Values.WattHours);

    public static readonly ColumnResponseBodyUnit Watts = new(Values.Watts);

    public static readonly ColumnResponseBodyUnit Weeks = new(Values.Weeks);

    public ColumnResponseBodyUnit(string value)
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
    public static ColumnResponseBodyUnit FromCustom(string value)
    {
        return new ColumnResponseBodyUnit(value);
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

    public static bool operator ==(ColumnResponseBodyUnit value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ColumnResponseBodyUnit value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ColumnResponseBodyUnit value) => value.Value;

    public static explicit operator ColumnResponseBodyUnit(string value) => new(value);

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
