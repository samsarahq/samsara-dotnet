using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<ReadingDatapointRequestBodyEntityType>))]
[Serializable]
public readonly record struct ReadingDatapointRequestBodyEntityType : IStringEnum
{
    public static readonly ReadingDatapointRequestBodyEntityType Asset = new(Values.Asset);

    public ReadingDatapointRequestBodyEntityType(string value)
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
    public static ReadingDatapointRequestBodyEntityType FromCustom(string value)
    {
        return new ReadingDatapointRequestBodyEntityType(value);
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

    public static bool operator ==(ReadingDatapointRequestBodyEntityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ReadingDatapointRequestBodyEntityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ReadingDatapointRequestBodyEntityType value) =>
        value.Value;

    public static explicit operator ReadingDatapointRequestBodyEntityType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Asset = "asset";
    }
}
