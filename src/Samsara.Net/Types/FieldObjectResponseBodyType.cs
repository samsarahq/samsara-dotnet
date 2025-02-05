using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FieldObjectResponseBodyType>))]
public enum FieldObjectResponseBodyType
{
    [EnumMember(Value = "photo")]
    Photo,

    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "multipleChoice")]
    MultipleChoice,

    [EnumMember(Value = "signature")]
    Signature,

    [EnumMember(Value = "dateTime")]
    DateTime,

    [EnumMember(Value = "scannedDocument")]
    ScannedDocument,

    [EnumMember(Value = "barcode")]
    Barcode,
}
