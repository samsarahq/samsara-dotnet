using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UserAuthType>))]
public enum UserAuthType
{
    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "saml")]
    Saml,
}
