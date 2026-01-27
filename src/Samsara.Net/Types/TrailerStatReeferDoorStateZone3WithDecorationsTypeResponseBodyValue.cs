using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue>)
)]
[Serializable]
public readonly record struct TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue
    : IStringEnum
{
    public static readonly TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue Open =
        new(Values.Open);

    public static readonly TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue Closed =
        new(Values.Closed);

    public TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue(string value)
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
    public static TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue FromCustom(
        string value
    )
    {
        return new TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue(value);
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
        TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue value
    ) => value.Value;

    public static explicit operator TrailerStatReeferDoorStateZone3WithDecorationsTypeResponseBodyValue(
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
