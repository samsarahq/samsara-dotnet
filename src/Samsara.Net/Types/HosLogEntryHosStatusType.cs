using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HosLogEntryHosStatusType>))]
public enum HosLogEntryHosStatusType
{
    [EnumMember(Value = "offDuty")]
    OffDuty,

    [EnumMember(Value = "sleeperBed")]
    SleeperBed,

    [EnumMember(Value = "driving")]
    Driving,

    [EnumMember(Value = "onDuty")]
    OnDuty,

    [EnumMember(Value = "yardMove")]
    YardMove,

    [EnumMember(Value = "personalConveyance")]
    PersonalConveyance,
}
