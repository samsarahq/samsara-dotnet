using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<MediaObjectResponseBodyMediaType>))]
public enum MediaObjectResponseBodyMediaType
{
    [EnumMember(Value = "image")]
    Image,

    [EnumMember(Value = "video")]
    Video,
}
