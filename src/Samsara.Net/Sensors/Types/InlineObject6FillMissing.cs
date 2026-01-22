using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Sensors;

[JsonConverter(typeof(StringEnumSerializer<InlineObject6FillMissing>))]
[Serializable]
public readonly record struct InlineObject6FillMissing : IStringEnum
{
    public static readonly InlineObject6FillMissing WithNull = new(Values.WithNull);

    public static readonly InlineObject6FillMissing WithPrevious = new(Values.WithPrevious);

    public InlineObject6FillMissing(string value)
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
    public static InlineObject6FillMissing FromCustom(string value)
    {
        return new InlineObject6FillMissing(value);
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

    public static bool operator ==(InlineObject6FillMissing value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(InlineObject6FillMissing value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(InlineObject6FillMissing value) => value.Value;

    public static explicit operator InlineObject6FillMissing(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string WithNull = "withNull";

        public const string WithPrevious = "withPrevious";
    }
}
