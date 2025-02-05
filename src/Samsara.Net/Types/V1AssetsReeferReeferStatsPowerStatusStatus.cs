using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<V1AssetsReeferReeferStatsPowerStatusStatus>))]
public enum V1AssetsReeferReeferStatsPowerStatusStatus
{
    [EnumMember(Value = "Off")]
    Off,

    [EnumMember(Value = "Active")]
    Active,

    [EnumMember(Value = "Active (Start/Stop)")]
    ActiveStartStop,

    [EnumMember(Value = "Active (Continuous)")]
    ActiveContinuous,
}
