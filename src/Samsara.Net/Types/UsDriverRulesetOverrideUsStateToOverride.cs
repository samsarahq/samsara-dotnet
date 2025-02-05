using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UsDriverRulesetOverrideUsStateToOverride>))]
public enum UsDriverRulesetOverrideUsStateToOverride
{
    [EnumMember(Value = "")]
    Empty,

    [EnumMember(Value = "AK")]
    Ak,

    [EnumMember(Value = "CA")]
    Ca,

    [EnumMember(Value = "FL")]
    Fl,

    [EnumMember(Value = "NE")]
    Ne,

    [EnumMember(Value = "NC")]
    Nc,

    [EnumMember(Value = "OK")]
    Ok,

    [EnumMember(Value = "OR")]
    Or,

    [EnumMember(Value = "SC")]
    Sc,

    [EnumMember(Value = "TX")]
    Tx,

    [EnumMember(Value = "WI")]
    Wi,
}
