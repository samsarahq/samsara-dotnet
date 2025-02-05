using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HosEldEventObjectResponseBodyMalfunctionDiagnosticCode>))]
public enum HosEldEventObjectResponseBodyMalfunctionDiagnosticCode
{
    [EnumMember(Value = "P")]
    P,

    [EnumMember(Value = "E")]
    E,

    [EnumMember(Value = "T")]
    T,

    [EnumMember(Value = "L")]
    L,

    [EnumMember(Value = "R")]
    R,

    [EnumMember(Value = "S")]
    S,

    [EnumMember(Value = "O")]
    O,

    [EnumMember(Value = "1")]
    One,

    [EnumMember(Value = "2")]
    Two,

    [EnumMember(Value = "3")]
    Three,

    [EnumMember(Value = "4")]
    Four,

    [EnumMember(Value = "5")]
    Five,

    [EnumMember(Value = "6")]
    Six,
}
