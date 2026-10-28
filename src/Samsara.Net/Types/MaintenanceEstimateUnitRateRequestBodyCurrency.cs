using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateUnitRateRequestBodyCurrency>))]
[Serializable]
public readonly record struct MaintenanceEstimateUnitRateRequestBodyCurrency : IStringEnum
{
    public static readonly MaintenanceEstimateUnitRateRequestBodyCurrency Usd = new(Values.Usd);

    public static readonly MaintenanceEstimateUnitRateRequestBodyCurrency Gbp = new(Values.Gbp);

    public static readonly MaintenanceEstimateUnitRateRequestBodyCurrency Cad = new(Values.Cad);

    public static readonly MaintenanceEstimateUnitRateRequestBodyCurrency Eur = new(Values.Eur);

    public static readonly MaintenanceEstimateUnitRateRequestBodyCurrency Chf = new(Values.Chf);

    public static readonly MaintenanceEstimateUnitRateRequestBodyCurrency Mxn = new(Values.Mxn);

    public MaintenanceEstimateUnitRateRequestBodyCurrency(string value)
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
    public static MaintenanceEstimateUnitRateRequestBodyCurrency FromCustom(string value)
    {
        return new MaintenanceEstimateUnitRateRequestBodyCurrency(value);
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
        MaintenanceEstimateUnitRateRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateUnitRateRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceEstimateUnitRateRequestBodyCurrency value) =>
        value.Value;

    public static explicit operator MaintenanceEstimateUnitRateRequestBodyCurrency(string value) =>
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
