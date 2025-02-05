using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RecipientObjectResponseBodyType>))]
public enum RecipientObjectResponseBodyType
{
    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "role")]
    Role,
}
