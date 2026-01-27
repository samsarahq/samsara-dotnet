using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AssetsInputsResponseResponseBodyUnits>))]
[Serializable]
public readonly record struct AssetsInputsResponseResponseBodyUnits : IStringEnum
{
    public static readonly AssetsInputsResponseResponseBodyUnits Boolean = new(Values.Boolean);

    public static readonly AssetsInputsResponseResponseBodyUnits Millivolts = new(
        Values.Millivolts
    );

    public static readonly AssetsInputsResponseResponseBodyUnits Microamps = new(Values.Microamps);

    public AssetsInputsResponseResponseBodyUnits(string value)
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
    public static AssetsInputsResponseResponseBodyUnits FromCustom(string value)
    {
        return new AssetsInputsResponseResponseBodyUnits(value);
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

    public static bool operator ==(AssetsInputsResponseResponseBodyUnits value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsInputsResponseResponseBodyUnits value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsInputsResponseResponseBodyUnits value) =>
        value.Value;

    public static explicit operator AssetsInputsResponseResponseBodyUnits(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Boolean = "boolean";

        public const string Millivolts = "millivolts";

        public const string Microamps = "microamps";
    }
}
