using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VoiceCoachingSettingsObjectResponseBodyLanguage>))]
public enum VoiceCoachingSettingsObjectResponseBodyLanguage
{
    [EnumMember(Value = "english")]
    English,

    [EnumMember(Value = "spanish")]
    Spanish,

    [EnumMember(Value = "dutch")]
    Dutch,

    [EnumMember(Value = "englishUk")]
    EnglishUk,

    [EnumMember(Value = "italian")]
    Italian,

    [EnumMember(Value = "french")]
    French,

    [EnumMember(Value = "german")]
    German,
}
