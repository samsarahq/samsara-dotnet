using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WorkerSafetySosDataResponseBodySourceType>))]
[Serializable]
public readonly record struct WorkerSafetySosDataResponseBodySourceType : IStringEnum
{
    public static readonly WorkerSafetySosDataResponseBodySourceType AppSos = new(Values.AppSos);

    public static readonly WorkerSafetySosDataResponseBodySourceType NoResponseCheckIn = new(
        Values.NoResponseCheckIn
    );

    public static readonly WorkerSafetySosDataResponseBodySourceType WearableSos = new(
        Values.WearableSos
    );

    public static readonly WorkerSafetySosDataResponseBodySourceType FallDetected = new(
        Values.FallDetected
    );

    public WorkerSafetySosDataResponseBodySourceType(string value)
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
    public static WorkerSafetySosDataResponseBodySourceType FromCustom(string value)
    {
        return new WorkerSafetySosDataResponseBodySourceType(value);
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
        WorkerSafetySosDataResponseBodySourceType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WorkerSafetySosDataResponseBodySourceType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WorkerSafetySosDataResponseBodySourceType value) =>
        value.Value;

    public static explicit operator WorkerSafetySosDataResponseBodySourceType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AppSos = "appSos";

        public const string NoResponseCheckIn = "noResponseCheckIn";

        public const string WearableSos = "wearableSos";

        public const string FallDetected = "fallDetected";
    }
}
