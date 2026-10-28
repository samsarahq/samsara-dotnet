using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateObjectResponseBodyEstimateType>))]
[Serializable]
public readonly record struct MaintenanceEstimateObjectResponseBodyEstimateType : IStringEnum
{
    public static readonly MaintenanceEstimateObjectResponseBodyEstimateType Unknown = new(
        Values.Unknown
    );

    public static readonly MaintenanceEstimateObjectResponseBodyEstimateType ExpectedCost = new(
        Values.ExpectedCost
    );

    public static readonly MaintenanceEstimateObjectResponseBodyEstimateType VendorQuote = new(
        Values.VendorQuote
    );

    public MaintenanceEstimateObjectResponseBodyEstimateType(string value)
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
    public static MaintenanceEstimateObjectResponseBodyEstimateType FromCustom(string value)
    {
        return new MaintenanceEstimateObjectResponseBodyEstimateType(value);
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
        MaintenanceEstimateObjectResponseBodyEstimateType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateObjectResponseBodyEstimateType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimateObjectResponseBodyEstimateType value
    ) => value.Value;

    public static explicit operator MaintenanceEstimateObjectResponseBodyEstimateType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string ExpectedCost = "expectedCost";

        public const string VendorQuote = "vendorQuote";
    }
}
