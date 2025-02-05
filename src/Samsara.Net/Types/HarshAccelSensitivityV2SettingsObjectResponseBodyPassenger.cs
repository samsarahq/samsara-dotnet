using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger>))]
public enum HarshAccelSensitivityV2SettingsObjectResponseBodyPassenger
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
