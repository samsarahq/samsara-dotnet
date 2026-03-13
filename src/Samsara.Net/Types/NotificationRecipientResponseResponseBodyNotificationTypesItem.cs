using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<NotificationRecipientResponseResponseBodyNotificationTypesItem>)
)]
[Serializable]
public readonly record struct NotificationRecipientResponseResponseBodyNotificationTypesItem
    : IStringEnum
{
    public static readonly NotificationRecipientResponseResponseBodyNotificationTypesItem Email =
        new(Values.Email);

    public NotificationRecipientResponseResponseBodyNotificationTypesItem(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static NotificationRecipientResponseResponseBodyNotificationTypesItem FromCustom(
        string value
    )
    {
        return new NotificationRecipientResponseResponseBodyNotificationTypesItem(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        NotificationRecipientResponseResponseBodyNotificationTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        NotificationRecipientResponseResponseBodyNotificationTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        NotificationRecipientResponseResponseBodyNotificationTypesItem value
    ) => value.Value;

    public static explicit operator NotificationRecipientResponseResponseBodyNotificationTypesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Email = "email";
    }
}
