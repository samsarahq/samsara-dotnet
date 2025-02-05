using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<OperationalSettingsObjectResponseBodyTimeRangeType>))]
public enum OperationalSettingsObjectResponseBodyTimeRangeType
{
    [EnumMember(Value = "activeBetween")]
    ActiveBetween,

    [EnumMember(Value = "inactiveBetween")]
    InactiveBetween,
}
