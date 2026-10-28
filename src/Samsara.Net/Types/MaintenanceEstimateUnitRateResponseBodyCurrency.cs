using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateUnitRateResponseBodyCurrency>))]
[Serializable]
public readonly record struct MaintenanceEstimateUnitRateResponseBodyCurrency : IStringEnum
{
    public static readonly MaintenanceEstimateUnitRateResponseBodyCurrency Usd = new(Values.Usd);

    public static readonly MaintenanceEstimateUnitRateResponseBodyCurrency Gbp = new(Values.Gbp);

    public static readonly MaintenanceEstimateUnitRateResponseBodyCurrency Cad = new(Values.Cad);

    public static readonly MaintenanceEstimateUnitRateResponseBodyCurrency Eur = new(Values.Eur);

    public static readonly MaintenanceEstimateUnitRateResponseBodyCurrency Chf = new(Values.Chf);

    public static readonly MaintenanceEstimateUnitRateResponseBodyCurrency Mxn = new(Values.Mxn);

    public MaintenanceEstimateUnitRateResponseBodyCurrency(string value)
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
    public static MaintenanceEstimateUnitRateResponseBodyCurrency FromCustom(string value)
    {
        return new MaintenanceEstimateUnitRateResponseBodyCurrency(value);
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
        MaintenanceEstimateUnitRateResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateUnitRateResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceEstimateUnitRateResponseBodyCurrency value) =>
        value.Value;

    public static explicit operator MaintenanceEstimateUnitRateResponseBodyCurrency(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Usd = "usd";

        public const string Gbp = "gbp";

        public const string Cad = "cad";

        public const string Eur = "eur";

        public const string Chf = "chf";

        public const string Mxn = "mxn";
    }
}
