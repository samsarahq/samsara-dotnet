using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<ReadingTypeResponseBodyDataType>))]
public enum ReadingTypeResponseBodyDataType
{
    [EnumMember(Value = "integer")]
    Integer,

    [EnumMember(Value = "float")]
    Float,

    [EnumMember(Value = "string")]
    String,
}
