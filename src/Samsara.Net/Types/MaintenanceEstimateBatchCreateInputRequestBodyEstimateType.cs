using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<MaintenanceEstimateBatchCreateInputRequestBodyEstimateType>)
)]
[Serializable]
public readonly record struct MaintenanceEstimateBatchCreateInputRequestBodyEstimateType
    : IStringEnum
{
    public static readonly MaintenanceEstimateBatchCreateInputRequestBodyEstimateType ExpectedCost =
        new(Values.ExpectedCost);

    public static readonly MaintenanceEstimateBatchCreateInputRequestBodyEstimateType VendorQuote =
        new(Values.VendorQuote);

    public MaintenanceEstimateBatchCreateInputRequestBodyEstimateType(string value)
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
    public static MaintenanceEstimateBatchCreateInputRequestBodyEstimateType FromCustom(
        string value
    )
    {
        return new MaintenanceEstimateBatchCreateInputRequestBodyEstimateType(value);
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
        MaintenanceEstimateBatchCreateInputRequestBodyEstimateType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateBatchCreateInputRequestBodyEstimateType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimateBatchCreateInputRequestBodyEstimateType value
    ) => value.Value;

    public static explicit operator MaintenanceEstimateBatchCreateInputRequestBodyEstimateType(
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
