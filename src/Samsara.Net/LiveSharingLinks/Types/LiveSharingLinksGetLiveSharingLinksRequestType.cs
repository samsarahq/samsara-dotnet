using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LiveSharingLinks;

[JsonConverter(typeof(EnumSerializer<LiveSharingLinksGetLiveSharingLinksRequestType>))]
public enum LiveSharingLinksGetLiveSharingLinksRequestType
{
    [EnumMember(Value = "all")]
    All,

    [EnumMember(Value = "assetsLocation")]
    AssetsLocation,

    [EnumMember(Value = "assetsNearLocation")]
    AssetsNearLocation,

    [EnumMember(Value = "assetsOnRoute")]
    AssetsOnRoute,
}
