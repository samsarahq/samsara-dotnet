using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<RecipientObjectRequestBodyNotificationTypesItem>))]
public enum RecipientObjectRequestBodyNotificationTypesItem
{
    [EnumMember(Value = "push")]
    Push,

    [EnumMember(Value = "sms")]
    Sms,

    [EnumMember(Value = "email")]
    Email,
}
