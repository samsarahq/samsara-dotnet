using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Cameras.Media.Retrieval;

[JsonConverter(typeof(EnumSerializer<MediaRetrievalPostMediaRetrievalRequestBodyMediaType>))]
public enum MediaRetrievalPostMediaRetrievalRequestBodyMediaType
{
    [EnumMember(Value = "image")]
    Image,

    [EnumMember(Value = "videoHighRes")]
    VideoHighRes,
}
