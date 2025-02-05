using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DocumentResponseObjectResponseBodyState>))]
public enum DocumentResponseObjectResponseBodyState
{
    [EnumMember(Value = "submitted")]
    Submitted,

    [EnumMember(Value = "required")]
    Required,

    [EnumMember(Value = "archived")]
    Archived,
}
