using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Vehicles;

[JsonConverter(typeof(EnumSerializer<UpdateVehicleRequestHarshAccelerationSettingType>))]
public enum UpdateVehicleRequestHarshAccelerationSettingType
{
    [EnumMember(Value = "passengerCar")]
    PassengerCar,

    [EnumMember(Value = "lightTruck")]
    LightTruck,

    [EnumMember(Value = "heavyDuty")]
    HeavyDuty,

    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "automatic")]
    Automatic,
}
