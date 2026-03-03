using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<NotificationRecipientRequestBodyNotificationTypesItem>))]
[Serializable]
public readonly record struct NotificationRecipientRequestBodyNotificationTypesItem : IStringEnum
{
    public static readonly NotificationRecipientRequestBodyNotificationTypesItem Email = new(
        Values.Email
    );

    public NotificationRecipientRequestBodyNotificationTypesItem(string value)
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
    public static NotificationRecipientRequestBodyNotificationTypesItem FromCustom(string value)
    {
        return new NotificationRecipientRequestBodyNotificationTypesItem(value);
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
        NotificationRecipientRequestBodyNotificationTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        NotificationRecipientRequestBodyNotificationTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        NotificationRecipientRequestBodyNotificationTypesItem value
    ) => value.Value;

    public static explicit operator NotificationRecipientRequestBodyNotificationTypesItem(
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
