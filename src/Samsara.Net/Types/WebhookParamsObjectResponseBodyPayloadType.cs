using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhookParamsObjectResponseBodyPayloadType>))]
[Serializable]
public readonly record struct WebhookParamsObjectResponseBodyPayloadType : IStringEnum
{
    public static readonly WebhookParamsObjectResponseBodyPayloadType Legacy = new(Values.Legacy);

    public static readonly WebhookParamsObjectResponseBodyPayloadType Enriched = new(
        Values.Enriched
    );

    public WebhookParamsObjectResponseBodyPayloadType(string value)
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
    public static WebhookParamsObjectResponseBodyPayloadType FromCustom(string value)
    {
        return new WebhookParamsObjectResponseBodyPayloadType(value);
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
        WebhookParamsObjectResponseBodyPayloadType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebhookParamsObjectResponseBodyPayloadType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WebhookParamsObjectResponseBodyPayloadType value) =>
        value.Value;

    public static explicit operator WebhookParamsObjectResponseBodyPayloadType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Legacy = "legacy";

        public const string Enriched = "enriched";
    }
}
