using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.CarbCtc;

[JsonConverter(typeof(StringEnumSerializer<ListCarbCtcVehiclesRequestTestStatusItem>))]
[Serializable]
public readonly record struct ListCarbCtcVehiclesRequestTestStatusItem : IStringEnum
{
    public static readonly ListCarbCtcVehiclesRequestTestStatusItem NotScheduled = new(
        Values.NotScheduled
    );

    public static readonly ListCarbCtcVehiclesRequestTestStatusItem Scheduled = new(
        Values.Scheduled
    );

    public static readonly ListCarbCtcVehiclesRequestTestStatusItem InProgress = new(
        Values.InProgress
    );

    public static readonly ListCarbCtcVehiclesRequestTestStatusItem AwaitingResult = new(
        Values.AwaitingResult
    );

    public static readonly ListCarbCtcVehiclesRequestTestStatusItem Pass = new(Values.Pass);

    public static readonly ListCarbCtcVehiclesRequestTestStatusItem Fail = new(Values.Fail);

    public static readonly ListCarbCtcVehiclesRequestTestStatusItem Error = new(Values.Error);

    public static readonly ListCarbCtcVehiclesRequestTestStatusItem Unknown = new(Values.Unknown);

    public ListCarbCtcVehiclesRequestTestStatusItem(string value)
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
    public static ListCarbCtcVehiclesRequestTestStatusItem FromCustom(string value)
    {
        return new ListCarbCtcVehiclesRequestTestStatusItem(value);
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
        ListCarbCtcVehiclesRequestTestStatusItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListCarbCtcVehiclesRequestTestStatusItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListCarbCtcVehiclesRequestTestStatusItem value) =>
        value.Value;

    public static explicit operator ListCarbCtcVehiclesRequestTestStatusItem(string value) =>
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
