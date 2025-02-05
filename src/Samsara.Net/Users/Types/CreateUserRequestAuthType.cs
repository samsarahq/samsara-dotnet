using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Users;

[JsonConverter(typeof(EnumSerializer<CreateUserRequestAuthType>))]
public enum CreateUserRequestAuthType
{
    [EnumMember(Value = "default")]
    Default,

    [EnumMember(Value = "saml")]
    Saml,
}
