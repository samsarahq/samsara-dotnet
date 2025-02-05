using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(EnumSerializer<AttributesGetAttributeRequestEntityType>))]
public enum AttributesGetAttributeRequestEntityType
{
    [EnumMember(Value = "driver")]
    Driver,

    [EnumMember(Value = "asset")]
    Asset,
}
