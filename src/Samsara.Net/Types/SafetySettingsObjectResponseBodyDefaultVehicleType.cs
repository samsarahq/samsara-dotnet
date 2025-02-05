using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SafetySettingsObjectResponseBodyDefaultVehicleType>))]
public enum SafetySettingsObjectResponseBodyDefaultVehicleType
{
    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "automatic")]
    Automatic,

    [EnumMember(Value = "passengerCar")]
    PassengerCar,

    [EnumMember(Value = "lightTruck")]
    LightTruck,

    [EnumMember(Value = "heavyDuty")]
    HeavyDuty,
}
