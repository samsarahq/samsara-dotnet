using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus>)
)]
[Serializable]
public readonly record struct MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus
    : IStringEnum
{
    public static readonly MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus Unapproved =
        new(Values.Unapproved);

    public static readonly MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus Approved =
        new(Values.Approved);

    public static readonly MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus Denied =
        new(Values.Denied);

    public MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus(string value)
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
    public static MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus FromCustom(
        string value
    )
    {
        return new MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus(value);
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
        MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus value
    ) => value.Value;

    public static explicit operator MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyApprovalStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unapproved = "unapproved";

        public const string Approved = "approved";

        public const string Denied = "denied";
    }
}
