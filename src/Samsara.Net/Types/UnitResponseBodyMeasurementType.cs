using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UnitResponseBodyMeasurementType>))]
public enum UnitResponseBodyMeasurementType
{
    [EnumMember(Value = "acceleration")]
    Acceleration,

    [EnumMember(Value = "co2EmissionsPerVolumeRate")]
    Co2EmissionsPerVolumeRate,

    [EnumMember(Value = "currency")]
    Currency,

    [EnumMember(Value = "distance")]
    Distance,

    [EnumMember(Value = "drySpreadRate")]
    DrySpreadRate,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "energy")]
    Energy,

    [EnumMember(Value = "fuelEconomy")]
    FuelEconomy,

    [EnumMember(Value = "gaseousFuel")]
    GaseousFuel,

    [EnumMember(Value = "gaseousFuelEconomy")]
    GaseousFuelEconomy,

    [EnumMember(Value = "pressure")]
    Pressure,

    [EnumMember(Value = "ratio")]
    Ratio,

    [EnumMember(Value = "speed")]
    Speed,

    [EnumMember(Value = "temperature")]
    Temperature,

    [EnumMember(Value = "time")]
    Time,

    [EnumMember(Value = "voltage")]
    Voltage,

    [EnumMember(Value = "volume")]
    Volume,

    [EnumMember(Value = "weight")]
    Weight,

    [EnumMember(Value = "wetSpreadRate")]
    WetSpreadRate,
}
