using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(EnumSerializer<MediaRetrievalPostMediaRetrievalRequestBodyMediaType>))]
public enum MediaRetrievalPostMediaRetrievalRequestBodyMediaType
{
    [EnumMember(Value = "IMAGE")]
    Image,

    [EnumMember(Value = "VIDEO_HIGH_RES")]
    VideoHighRes,

    [EnumMember(Value = "VIDEO_LOW_RES")]
    VideoLowRes,
}
