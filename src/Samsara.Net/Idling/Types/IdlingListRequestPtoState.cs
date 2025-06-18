using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Idling;

[JsonConverter(typeof(EnumSerializer<IdlingListRequestPtoState>))]
public enum IdlingListRequestPtoState
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "inactive")]
    Inactive,
}
