using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Ifta;

[JsonConverter(typeof(EnumSerializer<IftaGetJurisdictionReportsRequestMonth>))]
public enum IftaGetJurisdictionReportsRequestMonth
{
    [EnumMember(Value = "January")]
    January,

    [EnumMember(Value = "February")]
    February,

    [EnumMember(Value = "March")]
    March,

    [EnumMember(Value = "April")]
    April,

    [EnumMember(Value = "May")]
    May,

    [EnumMember(Value = "June")]
    June,

    [EnumMember(Value = "July")]
    July,

    [EnumMember(Value = "August")]
    August,

    [EnumMember(Value = "September")]
    September,

    [EnumMember(Value = "October")]
    October,

    [EnumMember(Value = "November")]
    November,

    [EnumMember(Value = "December")]
    December,
}
