using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventV2BehaviorLabelsResponseBodySource>))]
[Serializable]
public readonly record struct SafetyEventV2BehaviorLabelsResponseBodySource : IStringEnum
{
    public static readonly SafetyEventV2BehaviorLabelsResponseBodySource Automated = new(
        Values.Automated
    );

    public static readonly SafetyEventV2BehaviorLabelsResponseBodySource UserGenerated = new(
        Values.UserGenerated
    );

    public SafetyEventV2BehaviorLabelsResponseBodySource(string value)
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
    public static SafetyEventV2BehaviorLabelsResponseBodySource FromCustom(string value)
    {
        return new SafetyEventV2BehaviorLabelsResponseBodySource(value);
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
        SafetyEventV2BehaviorLabelsResponseBodySource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventV2BehaviorLabelsResponseBodySource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventV2BehaviorLabelsResponseBodySource value) =>
        value.Value;

    public static explicit operator SafetyEventV2BehaviorLabelsResponseBodySource(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Automated = "automated";

        public const string UserGenerated = "userGenerated";
    }
}
