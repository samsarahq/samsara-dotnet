using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SpecificVehicleFaultCodeObjectRequestBodyType>))]
public enum SpecificVehicleFaultCodeObjectRequestBodyType
{
    [EnumMember(Value = "INVALID_FAULT_CODE_TYPE")]
    InvalidFaultCodeType,

    [EnumMember(Value = "J1939_DTC")]
    J1939Dtc,

    [EnumMember(Value = "J1939_SPN")]
    J1939Spn,

    [EnumMember(Value = "PASSENGER_DTC")]
    PassengerDtc,
}
