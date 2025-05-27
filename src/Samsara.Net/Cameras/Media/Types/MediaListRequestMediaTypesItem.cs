using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Cameras.Media;

[JsonConverter(typeof(EnumSerializer<MediaListRequestMediaTypesItem>))]
public enum MediaListRequestMediaTypesItem
{
    [EnumMember(Value = "image")]
    Image,

    [EnumMember(Value = "videoHighRes")]
    VideoHighRes,
}
