using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RecipientObjectRequestBodyNotificationTypesItem>))]
[Serializable]
public readonly record struct RecipientObjectRequestBodyNotificationTypesItem : IStringEnum
{
    public static readonly RecipientObjectRequestBodyNotificationTypesItem Push = new(Values.Push);

    public static readonly RecipientObjectRequestBodyNotificationTypesItem Sms = new(Values.Sms);

    public static readonly RecipientObjectRequestBodyNotificationTypesItem Email = new(
        Values.Email
    );

    public RecipientObjectRequestBodyNotificationTypesItem(string value)
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
    public static RecipientObjectRequestBodyNotificationTypesItem FromCustom(string value)
    {
        return new RecipientObjectRequestBodyNotificationTypesItem(value);
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
        RecipientObjectRequestBodyNotificationTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecipientObjectRequestBodyNotificationTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecipientObjectRequestBodyNotificationTypesItem value) =>
        value.Value;

    public static explicit operator RecipientObjectRequestBodyNotificationTypesItem(string value) =>
        new(value);

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
