using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CarbCtcVehicleHistoryObjectResponseBodyTestResult>))]
[Serializable]
public readonly record struct CarbCtcVehicleHistoryObjectResponseBodyTestResult : IStringEnum
{
    public static readonly CarbCtcVehicleHistoryObjectResponseBodyTestResult Pass = new(
        Values.Pass
    );

    public static readonly CarbCtcVehicleHistoryObjectResponseBodyTestResult Fail = new(
        Values.Fail
    );

    public static readonly CarbCtcVehicleHistoryObjectResponseBodyTestResult Error = new(
        Values.Error
    );

    public static readonly CarbCtcVehicleHistoryObjectResponseBodyTestResult Unknown = new(
        Values.Unknown
    );

    public CarbCtcVehicleHistoryObjectResponseBodyTestResult(string value)
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
    public static CarbCtcVehicleHistoryObjectResponseBodyTestResult FromCustom(string value)
    {
        return new CarbCtcVehicleHistoryObjectResponseBodyTestResult(value);
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
        CarbCtcVehicleHistoryObjectResponseBodyTestResult value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CarbCtcVehicleHistoryObjectResponseBodyTestResult value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CarbCtcVehicleHistoryObjectResponseBodyTestResult value
    ) => value.Value;

    public static explicit operator CarbCtcVehicleHistoryObjectResponseBodyTestResult(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pass = "pass";

        public const string Fail = "fail";

        public const string Error = "error";

        public const string Unknown = "unknown";
    }
}
