using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RecipientObjectResponseBodyNotificationTypesItem>))]
public enum RecipientObjectResponseBodyNotificationTypesItem
{
    [EnumMember(Value = "push")]
    Push,

    [EnumMember(Value = "sms")]
    Sms,

    [EnumMember(Value = "email")]
    Email,
}
