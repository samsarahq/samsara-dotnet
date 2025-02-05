using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty>))]
public enum HarshBrakeSensitivityV2SettingsObjectResponseBodyLightDuty
{
    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "invalid")]
    Invalid,

    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "veryLow")]
    VeryLow,

    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "normal")]
    Normal,

    [EnumMember(Value = "high")]
    High,
}
