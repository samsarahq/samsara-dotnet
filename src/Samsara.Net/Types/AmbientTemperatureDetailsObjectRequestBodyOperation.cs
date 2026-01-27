using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AmbientTemperatureDetailsObjectRequestBodyOperation>))]
[Serializable]
public readonly record struct AmbientTemperatureDetailsObjectRequestBodyOperation : IStringEnum
{
    public static readonly AmbientTemperatureDetailsObjectRequestBodyOperation Greater = new(
        Values.Greater
    );

    public static readonly AmbientTemperatureDetailsObjectRequestBodyOperation InsideRange = new(
        Values.InsideRange
    );

    public static readonly AmbientTemperatureDetailsObjectRequestBodyOperation Less = new(
        Values.Less
    );

    public static readonly AmbientTemperatureDetailsObjectRequestBodyOperation OutsideRange = new(
        Values.OutsideRange
    );

    public AmbientTemperatureDetailsObjectRequestBodyOperation(string value)
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
    public static AmbientTemperatureDetailsObjectRequestBodyOperation FromCustom(string value)
    {
        return new AmbientTemperatureDetailsObjectRequestBodyOperation(value);
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
        AmbientTemperatureDetailsObjectRequestBodyOperation value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AmbientTemperatureDetailsObjectRequestBodyOperation value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AmbientTemperatureDetailsObjectRequestBodyOperation value
    ) => value.Value;

    public static explicit operator AmbientTemperatureDetailsObjectRequestBodyOperation(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Greater = "GREATER";

        public const string InsideRange = "INSIDE_RANGE";

        public const string Less = "LESS";

        public const string OutsideRange = "OUTSIDE_RANGE";
    }
}
