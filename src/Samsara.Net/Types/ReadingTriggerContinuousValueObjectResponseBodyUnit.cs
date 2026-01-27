using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReadingTriggerContinuousValueObjectResponseBodyUnit>))]
[Serializable]
public readonly record struct ReadingTriggerContinuousValueObjectResponseBodyUnit : IStringEnum
{
    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Ampere = new(
        Values.Ampere
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Bar = new(
        Values.Bar
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Cad = new(
        Values.Cad
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Celsius = new(
        Values.Celsius
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Chf = new(
        Values.Chf
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Day = new(
        Values.Day
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Decimaldegrees = new(
        Values.Decimaldegrees
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Eur = new(
        Values.Eur
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Fahrenheit = new(
        Values.Fahrenheit
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Foot = new(
        Values.Foot
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Gallon = new(
        Values.Gallon
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Gallonperkilogram =
        new(Values.Gallonperkilogram);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Gallonsperhour = new(
        Values.Gallonsperhour
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Galpermi = new(
        Values.Galpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Gbp = new(
        Values.Gbp
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Gforce = new(
        Values.Gforce
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Gperliter = new(
        Values.Gperliter
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Gperm = new(
        Values.Gperm
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Hertz = new(
        Values.Hertz
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Hour = new(
        Values.Hour
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Imperialgallonperkilogram =
        new(Values.Imperialgallonperkilogram);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Impgallon = new(
        Values.Impgallon
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Impgallonsperhour =
        new(Values.Impgallonsperhour);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Impgalpermi = new(
        Values.Impgalpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Inch = new(
        Values.Inch
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kelvin = new(
        Values.Kelvin
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kgper100Kmgaseousfuel =
        new(Values.Kgper100Kmgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kgpergallon = new(
        Values.Kgpergallon
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kgperkm = new(
        Values.Kgperkm
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kgperliter = new(
        Values.Kgperliter
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kgpermi = new(
        Values.Kgpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kilogram = new(
        Values.Kilogram
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kilogramgaseousfuel =
        new(Values.Kilogramgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kilometer = new(
        Values.Kilometer
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kilopascal = new(
        Values.Kilopascal
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kilowatthour = new(
        Values.Kilowatthour
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kmperhr = new(
        Values.Kmperhr
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kmperl = new(
        Values.Kmperl
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Kmperlgaseousfuel =
        new(Values.Kmperlgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Lbpermi = new(
        Values.Lbpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Liter = new(
        Values.Liter
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Litergaseousfuel =
        new(Values.Litergaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Literperkilogram =
        new(Values.Literperkilogram);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Literpertonne = new(
        Values.Literpertonne
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Litersperhour = new(
        Values.Litersperhour
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Lper100Km = new(
        Values.Lper100Km
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Lper100Kmgaseousfuel =
        new(Values.Lper100Kmgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Lperkm = new(
        Values.Lperkm
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Lperm = new(
        Values.Lperm
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Meter = new(
        Values.Meter
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Meterspersec = new(
        Values.Meterspersec
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Mile = new(
        Values.Mile
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Milliknot = new(
        Values.Milliknot
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Millisecond = new(
        Values.Millisecond
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Millivolt = new(
        Values.Millivolt
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Minute = new(
        Values.Minute
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Mipergal = new(
        Values.Mipergal
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Miperhr = new(
        Values.Miperhr
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Miperimpgal = new(
        Values.Miperimpgal
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Month = new(
        Values.Month
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Mpgusgalgaseousfuel =
        new(Values.Mpgusgalgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Mpkggaseousfuel =
        new(Values.Mpkggaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Mxn = new(
        Values.Mxn
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Percent = new(
        Values.Percent
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Pound = new(
        Values.Pound
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit PoundsPerSquareInch =
        new(Values.PoundsPerSquareInch);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Poundspergallon =
        new(Values.Poundspergallon);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Poundsperliter = new(
        Values.Poundsperliter
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Rpm = new(
        Values.Rpm
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Second = new(
        Values.Second
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Usd = new(
        Values.Usd
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Usgallongaseousfuel =
        new(Values.Usgallongaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Volt = new(
        Values.Volt
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit VoltAmpere = new(
        Values.VoltAmpere
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit VoltAmpereReactive =
        new(Values.VoltAmpereReactive);

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Watt = new(
        Values.Watt
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Watthour = new(
        Values.Watthour
    );

    public static readonly ReadingTriggerContinuousValueObjectResponseBodyUnit Week = new(
        Values.Week
    );

    public ReadingTriggerContinuousValueObjectResponseBodyUnit(string value)
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
    public static ReadingTriggerContinuousValueObjectResponseBodyUnit FromCustom(string value)
    {
        return new ReadingTriggerContinuousValueObjectResponseBodyUnit(value);
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
        ReadingTriggerContinuousValueObjectResponseBodyUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReadingTriggerContinuousValueObjectResponseBodyUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReadingTriggerContinuousValueObjectResponseBodyUnit value
    ) => value.Value;

    public static explicit operator ReadingTriggerContinuousValueObjectResponseBodyUnit(
        string value
    ) => new(value);

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
