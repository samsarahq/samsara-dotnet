using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus>)
)]
[Serializable]
public readonly record struct MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus
    : IStringEnum
{
    public static readonly MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus Approved =
        new(Values.Approved);

    public static readonly MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus Denied =
        new(Values.Denied);

    public static readonly MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus Cancelled =
        new(Values.Cancelled);

    public MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus(string value)
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
    public static MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus FromCustom(
        string value
    )
    {
        return new MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus(value);
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
        MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus value
    ) => value.Value;

    public static explicit operator MaintenanceEstimatesPatchMaintenanceEstimateRequestBodyApprovalStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Approved = "approved";

        public const string Denied = "denied";

        public const string Cancelled = "cancelled";
    }
}
