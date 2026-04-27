using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverWorkflowObjectResponseBodyWorkflowType>))]
[Serializable]
public readonly record struct DriverWorkflowObjectResponseBodyWorkflowType : IStringEnum
{
    public static readonly DriverWorkflowObjectResponseBodyWorkflowType StartOfDay = new(
        Values.StartOfDay
    );

    public static readonly DriverWorkflowObjectResponseBodyWorkflowType EndOfDay = new(
        Values.EndOfDay
    );

    public static readonly DriverWorkflowObjectResponseBodyWorkflowType AssetSelection = new(
        Values.AssetSelection
    );

    public static readonly DriverWorkflowObjectResponseBodyWorkflowType LeaveAsset = new(
        Values.LeaveAsset
    );

    public static readonly DriverWorkflowObjectResponseBodyWorkflowType RidershipSafetyCheck = new(
        Values.RidershipSafetyCheck
    );

    public static readonly DriverWorkflowObjectResponseBodyWorkflowType StopArrival = new(
        Values.StopArrival
    );

    public DriverWorkflowObjectResponseBodyWorkflowType(string value)
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
    public static DriverWorkflowObjectResponseBodyWorkflowType FromCustom(string value)
    {
        return new DriverWorkflowObjectResponseBodyWorkflowType(value);
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
        DriverWorkflowObjectResponseBodyWorkflowType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DriverWorkflowObjectResponseBodyWorkflowType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DriverWorkflowObjectResponseBodyWorkflowType value) =>
        value.Value;

    public static explicit operator DriverWorkflowObjectResponseBodyWorkflowType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string StartOfDay = "startOfDay";

        public const string EndOfDay = "endOfDay";

        public const string AssetSelection = "assetSelection";

        public const string LeaveAsset = "leaveAsset";

        public const string RidershipSafetyCheck = "ridershipSafetyCheck";

        public const string StopArrival = "stopArrival";
    }
}
