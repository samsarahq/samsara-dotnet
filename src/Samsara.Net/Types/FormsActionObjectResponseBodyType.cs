using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsActionObjectResponseBodyType>))]
public enum FormsActionObjectResponseBodyType
{
    [EnumMember(Value = "askFollowupQuestion")]
    AskFollowupQuestion,

    [EnumMember(Value = "showSection")]
    ShowSection,

    [EnumMember(Value = "requirePhoto")]
    RequirePhoto,

    [EnumMember(Value = "requireNote")]
    RequireNote,

    [EnumMember(Value = "createIssue")]
    CreateIssue,
}
