using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CoachableEventLinkageResponseBodySourceType>))]
[Serializable]
public readonly record struct CoachableEventLinkageResponseBodySourceType : IStringEnum
{
    public static readonly CoachableEventLinkageResponseBodySourceType TriageEvent = new(
        Values.TriageEvent
    );

    public static readonly CoachableEventLinkageResponseBodySourceType HosViolation = new(
        Values.HosViolation
    );

    public static readonly CoachableEventLinkageResponseBodySourceType Idling = new(Values.Idling);

    public CoachableEventLinkageResponseBodySourceType(string value)
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
    public static CoachableEventLinkageResponseBodySourceType FromCustom(string value)
    {
        return new CoachableEventLinkageResponseBodySourceType(value);
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
        CoachableEventLinkageResponseBodySourceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CoachableEventLinkageResponseBodySourceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CoachableEventLinkageResponseBodySourceType value) =>
        value.Value;

    public static explicit operator CoachableEventLinkageResponseBodySourceType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string TriageEvent = "triageEvent";

        public const string HosViolation = "hosViolation";

        public const string Idling = "idling";
    }
}
