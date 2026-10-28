using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateObjectResponseBodyApprovalStatus>))]
[Serializable]
public readonly record struct MaintenanceEstimateObjectResponseBodyApprovalStatus : IStringEnum
{
    public static readonly MaintenanceEstimateObjectResponseBodyApprovalStatus Unknown = new(
        Values.Unknown
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalStatus Unapproved = new(
        Values.Unapproved
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalStatus Pending = new(
        Values.Pending
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalStatus Approved = new(
        Values.Approved
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalStatus Denied = new(
        Values.Denied
    );

    public static readonly MaintenanceEstimateObjectResponseBodyApprovalStatus Cancelled = new(
        Values.Cancelled
    );

    public MaintenanceEstimateObjectResponseBodyApprovalStatus(string value)
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
    public static MaintenanceEstimateObjectResponseBodyApprovalStatus FromCustom(string value)
    {
        return new MaintenanceEstimateObjectResponseBodyApprovalStatus(value);
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
        MaintenanceEstimateObjectResponseBodyApprovalStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateObjectResponseBodyApprovalStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimateObjectResponseBodyApprovalStatus value
    ) => value.Value;

    public static explicit operator MaintenanceEstimateObjectResponseBodyApprovalStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Unapproved = "unapproved";

        public const string Pending = "pending";

        public const string Approved = "approved";

        public const string Denied = "denied";

        public const string Cancelled = "cancelled";
    }
}
