using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReadingTriggerContinuousValueObjectRequestBodyUnit>))]
[Serializable]
public readonly record struct ReadingTriggerContinuousValueObjectRequestBodyUnit : IStringEnum
{
    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Ampere = new(
        Values.Ampere
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Bar = new(Values.Bar);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Cad = new(Values.Cad);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Celsius = new(
        Values.Celsius
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Chf = new(Values.Chf);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Day = new(Values.Day);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Decimaldegrees = new(
        Values.Decimaldegrees
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Eur = new(Values.Eur);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Fahrenheit = new(
        Values.Fahrenheit
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Foot = new(
        Values.Foot
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Gallon = new(
        Values.Gallon
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Gallonperkilogram =
        new(Values.Gallonperkilogram);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Gallonsperhour = new(
        Values.Gallonsperhour
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Galpermi = new(
        Values.Galpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Gbp = new(Values.Gbp);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Gforce = new(
        Values.Gforce
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Gperliter = new(
        Values.Gperliter
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Gperm = new(
        Values.Gperm
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Hertz = new(
        Values.Hertz
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Hour = new(
        Values.Hour
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Imperialgallonperkilogram =
        new(Values.Imperialgallonperkilogram);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Impgallon = new(
        Values.Impgallon
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Impgallonsperhour =
        new(Values.Impgallonsperhour);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Impgalpermi = new(
        Values.Impgalpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Inch = new(
        Values.Inch
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kelvin = new(
        Values.Kelvin
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kgper100Kmgaseousfuel =
        new(Values.Kgper100Kmgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kgpergallon = new(
        Values.Kgpergallon
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kgperkm = new(
        Values.Kgperkm
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kgperliter = new(
        Values.Kgperliter
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kgpermi = new(
        Values.Kgpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kilogram = new(
        Values.Kilogram
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kilogramgaseousfuel =
        new(Values.Kilogramgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kilometer = new(
        Values.Kilometer
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kilopascal = new(
        Values.Kilopascal
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kilowatthour = new(
        Values.Kilowatthour
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kmperhr = new(
        Values.Kmperhr
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kmperl = new(
        Values.Kmperl
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Kmperlgaseousfuel =
        new(Values.Kmperlgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Lbpermi = new(
        Values.Lbpermi
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Liter = new(
        Values.Liter
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Litergaseousfuel =
        new(Values.Litergaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Literperkilogram =
        new(Values.Literperkilogram);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Literpertonne = new(
        Values.Literpertonne
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Litersperhour = new(
        Values.Litersperhour
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Lper100Km = new(
        Values.Lper100Km
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Lper100Kmgaseousfuel =
        new(Values.Lper100Kmgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Lperkm = new(
        Values.Lperkm
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Lperm = new(
        Values.Lperm
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Meter = new(
        Values.Meter
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Meterspersec = new(
        Values.Meterspersec
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Mile = new(
        Values.Mile
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Milliknot = new(
        Values.Milliknot
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Millisecond = new(
        Values.Millisecond
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Millivolt = new(
        Values.Millivolt
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Minute = new(
        Values.Minute
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Mipergal = new(
        Values.Mipergal
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Miperhr = new(
        Values.Miperhr
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Miperimpgal = new(
        Values.Miperimpgal
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Month = new(
        Values.Month
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Mpgusgalgaseousfuel =
        new(Values.Mpgusgalgaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Mpkggaseousfuel = new(
        Values.Mpkggaseousfuel
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Mxn = new(Values.Mxn);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Percent = new(
        Values.Percent
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Pound = new(
        Values.Pound
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit PoundsPerSquareInch =
        new(Values.PoundsPerSquareInch);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Poundspergallon = new(
        Values.Poundspergallon
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Poundsperliter = new(
        Values.Poundsperliter
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Rpm = new(Values.Rpm);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Second = new(
        Values.Second
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Usd = new(Values.Usd);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Usgallongaseousfuel =
        new(Values.Usgallongaseousfuel);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Volt = new(
        Values.Volt
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit VoltAmpere = new(
        Values.VoltAmpere
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit VoltAmpereReactive =
        new(Values.VoltAmpereReactive);

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Watt = new(
        Values.Watt
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Watthour = new(
        Values.Watthour
    );

    public static readonly ReadingTriggerContinuousValueObjectRequestBodyUnit Week = new(
        Values.Week
    );

    public ReadingTriggerContinuousValueObjectRequestBodyUnit(string value)
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
    public static ReadingTriggerContinuousValueObjectRequestBodyUnit FromCustom(string value)
    {
        return new ReadingTriggerContinuousValueObjectRequestBodyUnit(value);
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
        ReadingTriggerContinuousValueObjectRequestBodyUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ReadingTriggerContinuousValueObjectRequestBodyUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ReadingTriggerContinuousValueObjectRequestBodyUnit value
    ) => value.Value;

    public static explicit operator ReadingTriggerContinuousValueObjectRequestBodyUnit(
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
