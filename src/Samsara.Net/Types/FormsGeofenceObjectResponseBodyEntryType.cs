using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsGeofenceObjectResponseBodyEntryType>))]
public enum FormsGeofenceObjectResponseBodyEntryType
{
    [EnumMember(Value = "tracked")]
    Tracked,

    [EnumMember(Value = "untracked")]
    Untracked,
}
