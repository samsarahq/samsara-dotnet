using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AuthorSignatureObjectResponseBodyType>))]
public enum AuthorSignatureObjectResponseBodyType
{
    [EnumMember(Value = "driver")]
    Driver,

    [EnumMember(Value = "mechanic")]
    Mechanic,
}
