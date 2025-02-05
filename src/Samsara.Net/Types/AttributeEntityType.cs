using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AttributeEntityType>))]
public enum AttributeEntityType
{
    [EnumMember(Value = "driver")]
    Driver,

    [EnumMember(Value = "asset")]
    Asset,
}
