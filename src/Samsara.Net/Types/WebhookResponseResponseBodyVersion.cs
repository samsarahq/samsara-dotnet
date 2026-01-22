using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhookResponseResponseBodyVersion>))]
[Serializable]
public readonly record struct WebhookResponseResponseBodyVersion : IStringEnum
{
    public static readonly WebhookResponseResponseBodyVersion TwoThousandEighteen0101 = new(
        Values.TwoThousandEighteen0101
    );

    public static readonly WebhookResponseResponseBodyVersion TwoThousandTwentyOne0609 = new(
        Values.TwoThousandTwentyOne0609
    );

    public WebhookResponseResponseBodyVersion(string value)
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
    public static WebhookResponseResponseBodyVersion FromCustom(string value)
    {
        return new WebhookResponseResponseBodyVersion(value);
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

    public static bool operator ==(WebhookResponseResponseBodyVersion value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WebhookResponseResponseBodyVersion value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WebhookResponseResponseBodyVersion value) => value.Value;

    public static explicit operator WebhookResponseResponseBodyVersion(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string TwoThousandEighteen0101 = "2018-01-01";

        public const string TwoThousandTwentyOne0609 = "2021-06-09";
    }
}
