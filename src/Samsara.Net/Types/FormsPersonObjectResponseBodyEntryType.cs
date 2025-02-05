using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsPersonObjectResponseBodyEntryType>))]
public enum FormsPersonObjectResponseBodyEntryType
{
    [EnumMember(Value = "tracked")]
    Tracked,

    [EnumMember(Value = "untracked")]
    Untracked,
}
