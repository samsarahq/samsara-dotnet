using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CarbCtcVehicleObjectResponseBodyTestStatus>))]
[Serializable]
public readonly record struct CarbCtcVehicleObjectResponseBodyTestStatus : IStringEnum
{
    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus NotScheduled = new(
        Values.NotScheduled
    );

    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus Scheduled = new(
        Values.Scheduled
    );

    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus InProgress = new(
        Values.InProgress
    );

    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus AwaitingResult = new(
        Values.AwaitingResult
    );

    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus Pass = new(Values.Pass);

    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus Fail = new(Values.Fail);

    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus Error = new(Values.Error);

    public static readonly CarbCtcVehicleObjectResponseBodyTestStatus Unknown = new(Values.Unknown);

    public CarbCtcVehicleObjectResponseBodyTestStatus(string value)
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
    public static CarbCtcVehicleObjectResponseBodyTestStatus FromCustom(string value)
    {
        return new CarbCtcVehicleObjectResponseBodyTestStatus(value);
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
        CarbCtcVehicleObjectResponseBodyTestStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CarbCtcVehicleObjectResponseBodyTestStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CarbCtcVehicleObjectResponseBodyTestStatus value) =>
        value.Value;

    public static explicit operator CarbCtcVehicleObjectResponseBodyTestStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string NotScheduled = "notScheduled";

        public const string Scheduled = "scheduled";

        public const string InProgress = "inProgress";

        public const string AwaitingResult = "awaitingResult";

        public const string Pass = "pass";

        public const string Fail = "fail";

        public const string Error = "error";

        public const string Unknown = "unknown";
    }
}
