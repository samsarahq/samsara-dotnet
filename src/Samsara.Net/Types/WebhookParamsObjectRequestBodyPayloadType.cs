using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhookParamsObjectRequestBodyPayloadType>))]
[Serializable]
public readonly record struct WebhookParamsObjectRequestBodyPayloadType : IStringEnum
{
    public static readonly WebhookParamsObjectRequestBodyPayloadType Legacy = new(Values.Legacy);

    public static readonly WebhookParamsObjectRequestBodyPayloadType Enriched = new(
        Values.Enriched
    );

    public WebhookParamsObjectRequestBodyPayloadType(string value)
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
    public static WebhookParamsObjectRequestBodyPayloadType FromCustom(string value)
    {
        return new WebhookParamsObjectRequestBodyPayloadType(value);
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
        WebhookParamsObjectRequestBodyPayloadType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebhookParamsObjectRequestBodyPayloadType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WebhookParamsObjectRequestBodyPayloadType value) =>
        value.Value;

    public static explicit operator WebhookParamsObjectRequestBodyPayloadType(string value) =>
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
