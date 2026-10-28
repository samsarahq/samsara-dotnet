using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateMoneyResponseBodyCurrency>))]
[Serializable]
public readonly record struct MaintenanceEstimateMoneyResponseBodyCurrency : IStringEnum
{
    public static readonly MaintenanceEstimateMoneyResponseBodyCurrency Usd = new(Values.Usd);

    public static readonly MaintenanceEstimateMoneyResponseBodyCurrency Gbp = new(Values.Gbp);

    public static readonly MaintenanceEstimateMoneyResponseBodyCurrency Cad = new(Values.Cad);

    public static readonly MaintenanceEstimateMoneyResponseBodyCurrency Eur = new(Values.Eur);

    public static readonly MaintenanceEstimateMoneyResponseBodyCurrency Chf = new(Values.Chf);

    public static readonly MaintenanceEstimateMoneyResponseBodyCurrency Mxn = new(Values.Mxn);

    public MaintenanceEstimateMoneyResponseBodyCurrency(string value)
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
    public static MaintenanceEstimateMoneyResponseBodyCurrency FromCustom(string value)
    {
        return new MaintenanceEstimateMoneyResponseBodyCurrency(value);
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
        MaintenanceEstimateMoneyResponseBodyCurrency value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateMoneyResponseBodyCurrency value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(MaintenanceEstimateMoneyResponseBodyCurrency value) =>
        value.Value;

    public static explicit operator MaintenanceEstimateMoneyResponseBodyCurrency(string value) =>
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
