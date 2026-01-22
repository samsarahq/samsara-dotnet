using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TrailerStatReeferDoorStateZone3TypeResponseBodyValue>))]
[Serializable]
public readonly record struct TrailerStatReeferDoorStateZone3TypeResponseBodyValue : IStringEnum
{
    public static readonly TrailerStatReeferDoorStateZone3TypeResponseBodyValue Open = new(
        Values.Open
    );

    public static readonly TrailerStatReeferDoorStateZone3TypeResponseBodyValue Closed = new(
        Values.Closed
    );

    public TrailerStatReeferDoorStateZone3TypeResponseBodyValue(string value)
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
    public static TrailerStatReeferDoorStateZone3TypeResponseBodyValue FromCustom(string value)
    {
        return new TrailerStatReeferDoorStateZone3TypeResponseBodyValue(value);
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
        TrailerStatReeferDoorStateZone3TypeResponseBodyValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrailerStatReeferDoorStateZone3TypeResponseBodyValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrailerStatReeferDoorStateZone3TypeResponseBodyValue value
    ) => value.Value;

    public static explicit operator TrailerStatReeferDoorStateZone3TypeResponseBodyValue(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Open = "open";

        public const string Closed = "closed";
    }
}
