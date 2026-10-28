using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateLineInputRequestBodyCostType>))]
[Serializable]
public readonly record struct MaintenanceEstimateLineInputRequestBodyCostType : IStringEnum
{
    public static readonly MaintenanceEstimateLineInputRequestBodyCostType Labor = new(
        Values.Labor
    );

    public static readonly MaintenanceEstimateLineInputRequestBodyCostType Parts = new(
        Values.Parts
    );

    public MaintenanceEstimateLineInputRequestBodyCostType(string value)
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
    public static MaintenanceEstimateLineInputRequestBodyCostType FromCustom(string value)
    {
        return new MaintenanceEstimateLineInputRequestBodyCostType(value);
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
        MaintenanceEstimateLineInputRequestBodyCostType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateLineInputRequestBodyCostType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceEstimateLineInputRequestBodyCostType value) =>
        value.Value;

    public static explicit operator MaintenanceEstimateLineInputRequestBodyCostType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Labor = "labor";

        public const string Parts = "parts";
    }
}
