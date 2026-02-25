using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AddressAddressTypesItem>))]
[Serializable]
public readonly record struct AddressAddressTypesItem : IStringEnum
{
    public static readonly AddressAddressTypesItem Yard = new(Values.Yard);

    public static readonly AddressAddressTypesItem ShortHaul = new(Values.ShortHaul);

    public static readonly AddressAddressTypesItem WorkforceSite = new(Values.WorkforceSite);

    public static readonly AddressAddressTypesItem RiskZone = new(Values.RiskZone);

    public static readonly AddressAddressTypesItem IndustrialSite = new(Values.IndustrialSite);

    public static readonly AddressAddressTypesItem AlertsOnly = new(Values.AlertsOnly);

    public static readonly AddressAddressTypesItem AgricultureSource = new(
        Values.AgricultureSource
    );

    public static readonly AddressAddressTypesItem AvoidanceZone = new(Values.AvoidanceZone);

    public static readonly AddressAddressTypesItem KnownGpsJammingZone = new(
        Values.KnownGpsJammingZone
    );

    public static readonly AddressAddressTypesItem AuthorizedZone = new(Values.AuthorizedZone);

    public static readonly AddressAddressTypesItem UnauthorizedZone = new(Values.UnauthorizedZone);

    public static readonly AddressAddressTypesItem Vendor = new(Values.Vendor);

    public static readonly AddressAddressTypesItem Inventory = new(Values.Inventory);

    public AddressAddressTypesItem(string value)
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
    public static AddressAddressTypesItem FromCustom(string value)
    {
        return new AddressAddressTypesItem(value);
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

    public static bool operator ==(AddressAddressTypesItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AddressAddressTypesItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AddressAddressTypesItem value) => value.Value;

    public static explicit operator AddressAddressTypesItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Yard = "yard";

        public const string ShortHaul = "shortHaul";

        public const string WorkforceSite = "workforceSite";

        public const string RiskZone = "riskZone";

        public const string IndustrialSite = "industrialSite";

        public const string AlertsOnly = "alertsOnly";

        public const string AgricultureSource = "agricultureSource";

        public const string AvoidanceZone = "avoidanceZone";

        public const string KnownGpsJammingZone = "knownGPSJammingZone";

        public const string AuthorizedZone = "authorizedZone";

        public const string UnauthorizedZone = "unauthorizedZone";

        public const string Vendor = "vendor";

        public const string Inventory = "inventory";
    }
}
