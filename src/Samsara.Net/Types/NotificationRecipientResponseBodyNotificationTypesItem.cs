using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<NotificationRecipientResponseBodyNotificationTypesItem>)
)]
[Serializable]
public readonly record struct NotificationRecipientResponseBodyNotificationTypesItem : IStringEnum
{
    public static readonly NotificationRecipientResponseBodyNotificationTypesItem Email = new(
        Values.Email
    );

    public NotificationRecipientResponseBodyNotificationTypesItem(string value)
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
    public static NotificationRecipientResponseBodyNotificationTypesItem FromCustom(string value)
    {
        return new NotificationRecipientResponseBodyNotificationTypesItem(value);
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
        NotificationRecipientResponseBodyNotificationTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        NotificationRecipientResponseBodyNotificationTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        NotificationRecipientResponseBodyNotificationTypesItem value
    ) => value.Value;

    public static explicit operator NotificationRecipientResponseBodyNotificationTypesItem(
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
