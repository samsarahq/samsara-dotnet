using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType>)
)]
[Serializable]
public readonly record struct MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType
    : IStringEnum
{
    public static readonly MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType ExpectedCost =
        new(Values.ExpectedCost);

    public static readonly MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType VendorQuote =
        new(Values.VendorQuote);

    public MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType(string value)
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
    public static MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType FromCustom(
        string value
    )
    {
        return new MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType(value);
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
        MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType value
    ) => value.Value;

    public static explicit operator MaintenanceEstimatesCreateMaintenanceEstimateRequestBodyEstimateType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ExpectedCost = "expectedCost";

        public const string VendorQuote = "vendorQuote";
    }
}
