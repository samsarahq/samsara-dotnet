using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[JsonConverter(typeof(EnumSerializer<UpdateDriverRequestDriverActivationStatus>))]
public enum UpdateDriverRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
