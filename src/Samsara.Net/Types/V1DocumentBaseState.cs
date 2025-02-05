using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<V1DocumentBaseState>))]
public enum V1DocumentBaseState
{
    [EnumMember(Value = "Required")]
    Required,

    [EnumMember(Value = "Submitted")]
    Submitted,

    [EnumMember(Value = "Archived")]
    Archived,
}
