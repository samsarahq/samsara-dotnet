using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HarshAccelSensitivityV2SettingsObjectResponseBodyLightDuty>))]
public enum HarshAccelSensitivityV2SettingsObjectResponseBodyLightDuty
{
    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "invalid")]
    Invalid,

    [EnumMember(Value = "off")]
    Off,

    [EnumMember(Value = "low")]
    Low,

    [EnumMember(Value = "normal")]
    Normal,

    [EnumMember(Value = "high")]
    High,
}
