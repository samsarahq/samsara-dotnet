using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[JsonConverter(typeof(StringEnumSerializer<GetDriverEfficiencyRequestDriverActivationStatus>))]
[Serializable]
public readonly record struct GetDriverEfficiencyRequestDriverActivationStatus : IStringEnum
{
    public static readonly GetDriverEfficiencyRequestDriverActivationStatus Active = new(
        Values.Active
    );

    public static readonly GetDriverEfficiencyRequestDriverActivationStatus Deactivated = new(
        Values.Deactivated
    );

    public GetDriverEfficiencyRequestDriverActivationStatus(string value)
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
    public static GetDriverEfficiencyRequestDriverActivationStatus FromCustom(string value)
    {
        return new GetDriverEfficiencyRequestDriverActivationStatus(value);
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
        GetDriverEfficiencyRequestDriverActivationStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetDriverEfficiencyRequestDriverActivationStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GetDriverEfficiencyRequestDriverActivationStatus value
    ) => value.Value;

    public static explicit operator GetDriverEfficiencyRequestDriverActivationStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Deactivated = "deactivated";
    }
}
