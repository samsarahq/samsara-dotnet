using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhooksPostWebhooksResponseBodyVersion>))]
[Serializable]
public readonly record struct WebhooksPostWebhooksResponseBodyVersion : IStringEnum
{
    public static readonly WebhooksPostWebhooksResponseBodyVersion TwoThousandEighteen0101 = new(
        Values.TwoThousandEighteen0101
    );

    public static readonly WebhooksPostWebhooksResponseBodyVersion TwoThousandTwentyOne0609 = new(
        Values.TwoThousandTwentyOne0609
    );

    public WebhooksPostWebhooksResponseBodyVersion(string value)
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
    public static WebhooksPostWebhooksResponseBodyVersion FromCustom(string value)
    {
        return new WebhooksPostWebhooksResponseBodyVersion(value);
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

    public static bool operator ==(WebhooksPostWebhooksResponseBodyVersion value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WebhooksPostWebhooksResponseBodyVersion value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WebhooksPostWebhooksResponseBodyVersion value) =>
        value.Value;

    public static explicit operator WebhooksPostWebhooksResponseBodyVersion(string value) =>
        new(value);

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
