using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverEldRulesetCycle>))]
public enum DriverEldRulesetCycle
{
    [EnumMember(Value = "USA 60 hour / 7 day")]
    Usa60Hour7Day,

    [EnumMember(Value = "USA 70 hour / 8 day")]
    Usa70Hour8Day,

    [EnumMember(Value = "AK 80 hour / 8 day")]
    Ak80Hour8Day,

    [EnumMember(Value = "AK 70 hour / 7 day")]
    Ak70Hour7Day,

    [EnumMember(Value = "CA 80 hour / 8 day")]
    Ca80Hour8Day,

    [EnumMember(Value = "CA 112 hour / 8 day")]
    Ca112Hour8Day,

    [EnumMember(Value = "FL 80 hour / 8 day")]
    Fl80Hour8Day,

    [EnumMember(Value = "FL 70 hour / 7 day")]
    Fl70Hour7Day,

    [EnumMember(Value = "NE 80 hour / 8 day")]
    Ne80Hour8Day,

    [EnumMember(Value = "NE 70 hour / 7 day")]
    Ne70Hour7Day,

    [EnumMember(Value = "NC 80 hour / 8 day")]
    Nc80Hour8Day,

    [EnumMember(Value = "NC 70 hour / 7 day")]
    Nc70Hour7Day,

    [EnumMember(Value = "OK 70 hour / 8 day")]
    Ok70Hour8Day,

    [EnumMember(Value = "OK 60 hour / 7 day")]
    Ok60Hour7Day,

    [EnumMember(Value = "OR 80 hour / 8 day")]
    Or80Hour8Day,

    [EnumMember(Value = "OR 70 hour / 7 day")]
    Or70Hour7Day,

    [EnumMember(Value = "SC 80 hour / 8 day")]
    Sc80Hour8Day,

    [EnumMember(Value = "SC 70 hour / 7 day")]
    Sc70Hour7Day,

    [EnumMember(Value = "TX 70 hour / 7 day")]
    Tx70Hour7Day,

    [EnumMember(Value = "WI 80 hour / 8 day")]
    Wi80Hour8Day,

    [EnumMember(Value = "WI 70 hour / 7 day")]
    Wi70Hour7Day,

    [EnumMember(Value = "Canada South Cycle 1 (70 hour / 7 day)")]
    CanadaSouthCycle170Hour7Day,

    [EnumMember(Value = "Canada South Cycle 2 (120 hour / 14 day)")]
    CanadaSouthCycle2120Hour14Day,

    [EnumMember(Value = "Canada North Cycle 1 (80 hour / 7 day)")]
    CanadaNorthCycle180Hour7Day,

    [EnumMember(Value = "Canada North Cycle 2 (120 hour / 14 day)")]
    CanadaNorthCycle2120Hour14Day,
}
