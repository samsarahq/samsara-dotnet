using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RecipientObjectResponseBodyNotificationTypesItem>))]
[Serializable]
public readonly record struct RecipientObjectResponseBodyNotificationTypesItem : IStringEnum
{
    public static readonly RecipientObjectResponseBodyNotificationTypesItem Push = new(Values.Push);

    public static readonly RecipientObjectResponseBodyNotificationTypesItem Sms = new(Values.Sms);

    public static readonly RecipientObjectResponseBodyNotificationTypesItem Email = new(
        Values.Email
    );

    public RecipientObjectResponseBodyNotificationTypesItem(string value)
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
    public static RecipientObjectResponseBodyNotificationTypesItem FromCustom(string value)
    {
        return new RecipientObjectResponseBodyNotificationTypesItem(value);
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
        RecipientObjectResponseBodyNotificationTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecipientObjectResponseBodyNotificationTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RecipientObjectResponseBodyNotificationTypesItem value
    ) => value.Value;

    public static explicit operator RecipientObjectResponseBodyNotificationTypesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Push = "push";

        public const string Sms = "sms";

        public const string Email = "email";
    }
}
