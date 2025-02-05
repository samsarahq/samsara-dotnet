using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[JsonConverter(typeof(EnumSerializer<UpdateDriverRequestLocale>))]
public enum UpdateDriverRequestLocale
{
    [EnumMember(Value = "us")]
    Us,

    [EnumMember(Value = "at")]
    At,

    [EnumMember(Value = "be")]
    Be,

    [EnumMember(Value = "ca")]
    Ca,

    [EnumMember(Value = "gb")]
    Gb,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "ie")]
    Ie,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "lu")]
    Lu,

    [EnumMember(Value = "mx")]
    Mx,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "ch")]
    Ch,

    [EnumMember(Value = "pr")]
    Pr,
}
