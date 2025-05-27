using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UploadedMediaObjectResponseBodyMediaType>))]
public enum UploadedMediaObjectResponseBodyMediaType
{
    [EnumMember(Value = "image")]
    Image,

    [EnumMember(Value = "video")]
    Video,
}
