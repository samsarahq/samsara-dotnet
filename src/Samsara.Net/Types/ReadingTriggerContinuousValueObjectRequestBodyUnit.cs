using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<ReadingTriggerContinuousValueObjectRequestBodyUnit>))]
public enum ReadingTriggerContinuousValueObjectRequestBodyUnit
{
    [EnumMember(Value = "bar")]
    Bar,

    [EnumMember(Value = "celsius")]
    Celsius,

    [EnumMember(Value = "fahrenheit")]
    Fahrenheit,

    [EnumMember(Value = "foot")]
    Foot,

    [EnumMember(Value = "gallon")]
    Gallon,

    [EnumMember(Value = "galpermi")]
    Galpermi,

    [EnumMember(Value = "gforce")]
    Gforce,

    [EnumMember(Value = "gperliter")]
    Gperliter,

    [EnumMember(Value = "gperm")]
    Gperm,

    [EnumMember(Value = "hour")]
    Hour,

    [EnumMember(Value = "impgallon")]
    Impgallon,

    [EnumMember(Value = "impgalpermi")]
    Impgalpermi,

    [EnumMember(Value = "inch")]
    Inch,

    [EnumMember(Value = "kelvin")]
    Kelvin,

    [EnumMember(Value = "kgper100kmgaseousfuel")]
    Kgper100Kmgaseousfuel,

    [EnumMember(Value = "kgpergallon")]
    Kgpergallon,

    [EnumMember(Value = "kgperkm")]
    Kgperkm,

    [EnumMember(Value = "kgperliter")]
    Kgperliter,

    [EnumMember(Value = "kgpermi")]
    Kgpermi,

    [EnumMember(Value = "kilogram")]
    Kilogram,

    [EnumMember(Value = "kilogramgaseousfuel")]
    Kilogramgaseousfuel,

    [EnumMember(Value = "kilometer")]
    Kilometer,

    [EnumMember(Value = "kilopascal")]
    Kilopascal,

    [EnumMember(Value = "kilowatthour")]
    Kilowatthour,

    [EnumMember(Value = "kmperhr")]
    Kmperhr,

    [EnumMember(Value = "lbpermi")]
    Lbpermi,

    [EnumMember(Value = "liter")]
    Liter,

    [EnumMember(Value = "litergaseousfuel")]
    Litergaseousfuel,

    [EnumMember(Value = "lper100km")]
    Lper100Km,

    [EnumMember(Value = "lper100kmgaseousfuel")]
    Lper100Kmgaseousfuel,

    [EnumMember(Value = "lperkm")]
    Lperkm,

    [EnumMember(Value = "lperm")]
    Lperm,

    [EnumMember(Value = "meter")]
    Meter,

    [EnumMember(Value = "meterspersec")]
    Meterspersec,

    [EnumMember(Value = "mile")]
    Mile,

    [EnumMember(Value = "milliknot")]
    Milliknot,

    [EnumMember(Value = "millisecond")]
    Millisecond,

    [EnumMember(Value = "millivolt")]
    Millivolt,

    [EnumMember(Value = "mipergal")]
    Mipergal,

    [EnumMember(Value = "miperhr")]
    Miperhr,

    [EnumMember(Value = "miperimpgal")]
    Miperimpgal,

    [EnumMember(Value = "mpgusgalgaseousfuel")]
    Mpgusgalgaseousfuel,

    [EnumMember(Value = "mpkggaseousfuel")]
    Mpkggaseousfuel,

    [EnumMember(Value = "percent")]
    Percent,

    [EnumMember(Value = "pound")]
    Pound,

    [EnumMember(Value = "poundsPerSquareInch")]
    PoundsPerSquareInch,

    [EnumMember(Value = "poundspergallon")]
    Poundspergallon,

    [EnumMember(Value = "poundsperliter")]
    Poundsperliter,

    [EnumMember(Value = "second")]
    Second,

    [EnumMember(Value = "usd")]
    Usd,

    [EnumMember(Value = "usgallongaseousfuel")]
    Usgallongaseousfuel,

    [EnumMember(Value = "volt")]
    Volt,

    [EnumMember(Value = "watthour")]
    Watthour,
}
