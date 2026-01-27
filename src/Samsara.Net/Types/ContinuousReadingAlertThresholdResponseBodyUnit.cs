using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ContinuousReadingAlertThresholdResponseBodyUnit>))]
[Serializable]
public readonly record struct ContinuousReadingAlertThresholdResponseBodyUnit : IStringEnum
{
    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Ampere = new(
        Values.Ampere
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Bar = new(Values.Bar);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Cad = new(Values.Cad);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Celsius = new(
        Values.Celsius
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Chf = new(Values.Chf);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Day = new(Values.Day);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Decimaldegrees = new(
        Values.Decimaldegrees
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Eur = new(Values.Eur);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Fahrenheit = new(
        Values.Fahrenheit
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Foot = new(Values.Foot);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Gallon = new(
        Values.Gallon
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Gallonperkilogram = new(
        Values.Gallonperkilogram
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Gallonsperhour = new(
        Values.Gallonsperhour
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Galpermi = new(
        Values.Galpermi
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Gbp = new(Values.Gbp);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Gforce = new(
        Values.Gforce
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Gperliter = new(
        Values.Gperliter
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Gperm = new(
        Values.Gperm
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Hertz = new(
        Values.Hertz
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Hour = new(Values.Hour);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Imperialgallonperkilogram =
        new(Values.Imperialgallonperkilogram);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Impgallon = new(
        Values.Impgallon
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Impgallonsperhour = new(
        Values.Impgallonsperhour
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Impgalpermi = new(
        Values.Impgalpermi
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Inch = new(Values.Inch);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kelvin = new(
        Values.Kelvin
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kgper100Kmgaseousfuel =
        new(Values.Kgper100Kmgaseousfuel);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kgpergallon = new(
        Values.Kgpergallon
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kgperkm = new(
        Values.Kgperkm
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kgperliter = new(
        Values.Kgperliter
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kgpermi = new(
        Values.Kgpermi
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kilogram = new(
        Values.Kilogram
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kilogramgaseousfuel =
        new(Values.Kilogramgaseousfuel);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kilometer = new(
        Values.Kilometer
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kilopascal = new(
        Values.Kilopascal
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kilowatthour = new(
        Values.Kilowatthour
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kmperhr = new(
        Values.Kmperhr
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kmperl = new(
        Values.Kmperl
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Kmperlgaseousfuel = new(
        Values.Kmperlgaseousfuel
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Lbpermi = new(
        Values.Lbpermi
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Liter = new(
        Values.Liter
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Litergaseousfuel = new(
        Values.Litergaseousfuel
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Literperkilogram = new(
        Values.Literperkilogram
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Literpertonne = new(
        Values.Literpertonne
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Litersperhour = new(
        Values.Litersperhour
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Lper100Km = new(
        Values.Lper100Km
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Lper100Kmgaseousfuel =
        new(Values.Lper100Kmgaseousfuel);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Lperkm = new(
        Values.Lperkm
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Lperm = new(
        Values.Lperm
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Meter = new(
        Values.Meter
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Meterspersec = new(
        Values.Meterspersec
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Mile = new(Values.Mile);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Milliknot = new(
        Values.Milliknot
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Millisecond = new(
        Values.Millisecond
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Millivolt = new(
        Values.Millivolt
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Minute = new(
        Values.Minute
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Mipergal = new(
        Values.Mipergal
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Miperhr = new(
        Values.Miperhr
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Miperimpgal = new(
        Values.Miperimpgal
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Month = new(
        Values.Month
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Mpgusgalgaseousfuel =
        new(Values.Mpgusgalgaseousfuel);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Mpkggaseousfuel = new(
        Values.Mpkggaseousfuel
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Mxn = new(Values.Mxn);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Percent = new(
        Values.Percent
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Pound = new(
        Values.Pound
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit PoundsPerSquareInch =
        new(Values.PoundsPerSquareInch);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Poundspergallon = new(
        Values.Poundspergallon
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Poundsperliter = new(
        Values.Poundsperliter
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Rpm = new(Values.Rpm);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Second = new(
        Values.Second
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Usd = new(Values.Usd);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Usgallongaseousfuel =
        new(Values.Usgallongaseousfuel);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Volt = new(Values.Volt);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit VoltAmpere = new(
        Values.VoltAmpere
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit VoltAmpereReactive = new(
        Values.VoltAmpereReactive
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Watt = new(Values.Watt);

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Watthour = new(
        Values.Watthour
    );

    public static readonly ContinuousReadingAlertThresholdResponseBodyUnit Week = new(Values.Week);

    public ContinuousReadingAlertThresholdResponseBodyUnit(string value)
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
    public static ContinuousReadingAlertThresholdResponseBodyUnit FromCustom(string value)
    {
        return new ContinuousReadingAlertThresholdResponseBodyUnit(value);
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

    public static bool operator ==(
        ContinuousReadingAlertThresholdResponseBodyUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ContinuousReadingAlertThresholdResponseBodyUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ContinuousReadingAlertThresholdResponseBodyUnit value) =>
        value.Value;

    public static explicit operator ContinuousReadingAlertThresholdResponseBodyUnit(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Ampere = "ampere";

        public const string Bar = "bar";

        public const string Cad = "cad";

        public const string Celsius = "celsius";

        public const string Chf = "chf";

        public const string Day = "day";

        public const string Decimaldegrees = "decimaldegrees";

        public const string Eur = "eur";

        public const string Fahrenheit = "fahrenheit";

        public const string Foot = "foot";

        public const string Gallon = "gallon";

        public const string Gallonperkilogram = "gallonperkilogram";

        public const string Gallonsperhour = "gallonsperhour";

        public const string Galpermi = "galpermi";

        public const string Gbp = "gbp";

        public const string Gforce = "gforce";

        public const string Gperliter = "gperliter";

        public const string Gperm = "gperm";

        public const string Hertz = "hertz";

        public const string Hour = "hour";

        public const string Imperialgallonperkilogram = "imperialgallonperkilogram";

        public const string Impgallon = "impgallon";

        public const string Impgallonsperhour = "impgallonsperhour";

        public const string Impgalpermi = "impgalpermi";

        public const string Inch = "inch";

        public const string Kelvin = "kelvin";

        public const string Kgper100Kmgaseousfuel = "kgper100kmgaseousfuel";

        public const string Kgpergallon = "kgpergallon";

        public const string Kgperkm = "kgperkm";

        public const string Kgperliter = "kgperliter";

        public const string Kgpermi = "kgpermi";

        public const string Kilogram = "kilogram";

        public const string Kilogramgaseousfuel = "kilogramgaseousfuel";

        public const string Kilometer = "kilometer";

        public const string Kilopascal = "kilopascal";

        public const string Kilowatthour = "kilowatthour";

        public const string Kmperhr = "kmperhr";

        public const string Kmperl = "kmperl";

        public const string Kmperlgaseousfuel = "kmperlgaseousfuel";

        public const string Lbpermi = "lbpermi";

        public const string Liter = "liter";

        public const string Litergaseousfuel = "litergaseousfuel";

        public const string Literperkilogram = "literperkilogram";

        public const string Literpertonne = "literpertonne";

        public const string Litersperhour = "litersperhour";

        public const string Lper100Km = "lper100km";

        public const string Lper100Kmgaseousfuel = "lper100kmgaseousfuel";

        public const string Lperkm = "lperkm";

        public const string Lperm = "lperm";

        public const string Meter = "meter";

        public const string Meterspersec = "meterspersec";

        public const string Mile = "mile";

        public const string Milliknot = "milliknot";

        public const string Millisecond = "millisecond";

        public const string Millivolt = "millivolt";

        public const string Minute = "minute";

        public const string Mipergal = "mipergal";

        public const string Miperhr = "miperhr";

        public const string Miperimpgal = "miperimpgal";

        public const string Month = "month";

        public const string Mpgusgalgaseousfuel = "mpgusgalgaseousfuel";

        public const string Mpkggaseousfuel = "mpkggaseousfuel";

        public const string Mxn = "mxn";

        public const string Percent = "percent";

        public const string Pound = "pound";

        public const string PoundsPerSquareInch = "poundsPerSquareInch";

        public const string Poundspergallon = "poundspergallon";

        public const string Poundsperliter = "poundsperliter";

        public const string Rpm = "rpm";

        public const string Second = "second";

        public const string Usd = "usd";

        public const string Usgallongaseousfuel = "usgallongaseousfuel";

        public const string Volt = "volt";

        public const string VoltAmpere = "voltAmpere";

        public const string VoltAmpereReactive = "voltAmpereReactive";

        public const string Watt = "watt";

        public const string Watthour = "watthour";

        public const string Week = "week";
    }
}
