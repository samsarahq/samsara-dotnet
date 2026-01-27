using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue>)
)]
[Serializable]
public readonly record struct TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue
    : IStringEnum
{
    public static readonly TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue Open =
        new(Values.Open);

    public static readonly TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue Closed =
        new(Values.Closed);

    public TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue(string value)
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
    public static TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue FromCustom(
        string value
    )
    {
        return new TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue(value);
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
        TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue value
    ) => value.Value;

    public static explicit operator TrailerStatReeferDoorStateZone2WithDecorationsTypeResponseBodyValue(
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
