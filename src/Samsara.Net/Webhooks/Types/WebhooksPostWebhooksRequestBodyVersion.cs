using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Webhooks;

[JsonConverter(typeof(StringEnumSerializer<WebhooksPostWebhooksRequestBodyVersion>))]
[Serializable]
public readonly record struct WebhooksPostWebhooksRequestBodyVersion : IStringEnum
{
    public static readonly WebhooksPostWebhooksRequestBodyVersion TwoThousandEighteen0101 = new(
        Values.TwoThousandEighteen0101
    );

    public static readonly WebhooksPostWebhooksRequestBodyVersion TwoThousandTwentyOne0609 = new(
        Values.TwoThousandTwentyOne0609
    );

    public static readonly WebhooksPostWebhooksRequestBodyVersion TwoThousandTwentyTwo0913 = new(
        Values.TwoThousandTwentyTwo0913
    );

    public static readonly WebhooksPostWebhooksRequestBodyVersion TwoThousandTwentyFour0227 = new(
        Values.TwoThousandTwentyFour0227
    );

    public WebhooksPostWebhooksRequestBodyVersion(string value)
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
    public static WebhooksPostWebhooksRequestBodyVersion FromCustom(string value)
    {
        return new WebhooksPostWebhooksRequestBodyVersion(value);
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

    public static bool operator ==(WebhooksPostWebhooksRequestBodyVersion value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WebhooksPostWebhooksRequestBodyVersion value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WebhooksPostWebhooksRequestBodyVersion value) =>
        value.Value;

    public static explicit operator WebhooksPostWebhooksRequestBodyVersion(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string TwoThousandEighteen0101 = "2018-01-01";

        public const string TwoThousandTwentyOne0609 = "2021-06-09";

        public const string TwoThousandTwentyTwo0913 = "2022-09-13";

        public const string TwoThousandTwentyFour0227 = "2024-02-27";
    }
}
