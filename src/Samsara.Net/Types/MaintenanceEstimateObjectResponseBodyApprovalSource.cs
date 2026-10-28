using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateObjectResponseBodyApprovalSource>))]
[Serializable]
public readonly record struct MaintenanceEstimateObjectResponseBodyApprovalSource : IStringEnum
{
    public static readonly MaintenanceEstimateObjectResponseBodyApprovalSource Unknown = new(
        Values.Unknown
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalSource None = new(
        Values.None
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalSource Policy = new(
        Values.Policy
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalSource Samsara = new(
        Values.Samsara
    );

    public MaintenanceEstimateObjectResponseBodyApprovalSource(string value)
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
    public static MaintenanceEstimateObjectResponseBodyApprovalSource FromCustom(string value)
    {
        return new MaintenanceEstimateObjectResponseBodyApprovalSource(value);
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
        MaintenanceEstimateObjectResponseBodyApprovalSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateObjectResponseBodyApprovalSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimateObjectResponseBodyApprovalSource value
    ) => value.Value;

    public static explicit operator MaintenanceEstimateObjectResponseBodyApprovalSource(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string None = "none";

        public const string Policy = "policy";

        public const string Samsara = "samsara";
    }
}
