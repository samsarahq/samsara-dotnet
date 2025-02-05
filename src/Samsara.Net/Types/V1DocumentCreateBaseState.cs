using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<V1DocumentCreateBaseState>))]
public enum V1DocumentCreateBaseState
{
    [EnumMember(Value = "Required")]
    Required,

    [EnumMember(Value = "Submitted")]
    Submitted,
}
