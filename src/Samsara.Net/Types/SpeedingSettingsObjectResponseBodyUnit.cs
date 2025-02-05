using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SpeedingSettingsObjectResponseBodyUnit>))]
public enum SpeedingSettingsObjectResponseBodyUnit
{
    [EnumMember(Value = "milesPerHour")]
    MilesPerHour,

    [EnumMember(Value = "kilometersPerHour")]
    KilometersPerHour,

    [EnumMember(Value = "percentage")]
    Percentage,
}
