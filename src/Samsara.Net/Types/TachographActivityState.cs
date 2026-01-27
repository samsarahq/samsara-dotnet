using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TachographActivityState>))]
[Serializable]
public readonly record struct TachographActivityState : IStringEnum
{
    public static readonly TachographActivityState BreakRest = new(Values.BreakRest);

    public static readonly TachographActivityState Work = new(Values.Work);

    public static readonly TachographActivityState Availability = new(Values.Availability);

    public static readonly TachographActivityState Driving = new(Values.Driving);

    public static readonly TachographActivityState Unknown = new(Values.Unknown);

    public TachographActivityState(string value)
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
    public static TachographActivityState FromCustom(string value)
    {
        return new TachographActivityState(value);
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

    public static bool operator ==(TachographActivityState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TachographActivityState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TachographActivityState value) => value.Value;

    public static explicit operator TachographActivityState(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string BreakRest = "BREAK/REST";

        public const string Work = "WORK";

        public const string Availability = "AVAILABILITY";

        public const string Driving = "DRIVING";

        public const string Unknown = "UNKNOWN";
    }
}
