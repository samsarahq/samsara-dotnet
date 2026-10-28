using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateLineItemResponseBodyCostType>))]
[Serializable]
public readonly record struct MaintenanceEstimateLineItemResponseBodyCostType : IStringEnum
{
    public static readonly MaintenanceEstimateLineItemResponseBodyCostType Unknown = new(
        Values.Unknown
    );

    public static readonly MaintenanceEstimateLineItemResponseBodyCostType Labor = new(
        Values.Labor
    );

    public static readonly MaintenanceEstimateLineItemResponseBodyCostType Parts = new(
        Values.Parts
    );

    public MaintenanceEstimateLineItemResponseBodyCostType(string value)
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
    public static MaintenanceEstimateLineItemResponseBodyCostType FromCustom(string value)
    {
        return new MaintenanceEstimateLineItemResponseBodyCostType(value);
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
        MaintenanceEstimateLineItemResponseBodyCostType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateLineItemResponseBodyCostType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceEstimateLineItemResponseBodyCostType value) =>
        value.Value;

    public static explicit operator MaintenanceEstimateLineItemResponseBodyCostType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Labor = "labor";

        public const string Parts = "parts";
    }
}
