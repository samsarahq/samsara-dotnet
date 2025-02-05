using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TachographActivityState>))]
public enum TachographActivityState
{
    [EnumMember(Value = "BREAK/REST")]
    BreakRest,

    [EnumMember(Value = "WORK")]
    Work,

    [EnumMember(Value = "AVAILABILITY")]
    Availability,

    [EnumMember(Value = "DRIVING")]
    Driving,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,
}
