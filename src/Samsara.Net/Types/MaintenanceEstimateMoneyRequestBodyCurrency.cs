using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateMoneyRequestBodyCurrency>))]
[Serializable]
public readonly record struct MaintenanceEstimateMoneyRequestBodyCurrency : IStringEnum
{
    public static readonly MaintenanceEstimateMoneyRequestBodyCurrency Usd = new(Values.Usd);

    public static readonly MaintenanceEstimateMoneyRequestBodyCurrency Gbp = new(Values.Gbp);

    public static readonly MaintenanceEstimateMoneyRequestBodyCurrency Cad = new(Values.Cad);

    public static readonly MaintenanceEstimateMoneyRequestBodyCurrency Eur = new(Values.Eur);

    public static readonly MaintenanceEstimateMoneyRequestBodyCurrency Chf = new(Values.Chf);

    public static readonly MaintenanceEstimateMoneyRequestBodyCurrency Mxn = new(Values.Mxn);

    public MaintenanceEstimateMoneyRequestBodyCurrency(string value)
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
    public static MaintenanceEstimateMoneyRequestBodyCurrency FromCustom(string value)
    {
        return new MaintenanceEstimateMoneyRequestBodyCurrency(value);
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
        MaintenanceEstimateMoneyRequestBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateMoneyRequestBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceEstimateMoneyRequestBodyCurrency value) =>
        value.Value;

    public static explicit operator MaintenanceEstimateMoneyRequestBodyCurrency(string value) =>
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
