using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem>))]
public enum VoiceCoachingSettingsObjectResponseBodyEventsToCoachItem
{
    [EnumMember(Value = "crash")]
    Crash,

    [EnumMember(Value = "inCabSpeeding")]
    InCabSpeeding,

    [EnumMember(Value = "maximumSpeed")]
    MaximumSpeed,

    [EnumMember(Value = "seatbeltUnbuckled")]
    SeatbeltUnbuckled,

    [EnumMember(Value = "harshDriving")]
    HarshDriving,
}
