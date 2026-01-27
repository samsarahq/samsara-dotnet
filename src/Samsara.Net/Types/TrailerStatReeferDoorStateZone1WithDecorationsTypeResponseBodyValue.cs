using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue>)
)]
[Serializable]
public readonly record struct TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue
    : IStringEnum
{
    public static readonly TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue Open =
        new(Values.Open);

    public static readonly TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue Closed =
        new(Values.Closed);

    public TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue(string value)
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
    public static TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue FromCustom(
        string value
    )
    {
        return new TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue(value);
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
        TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue value
    ) => value.Value;

    public static explicit operator TrailerStatReeferDoorStateZone1WithDecorationsTypeResponseBodyValue(
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
