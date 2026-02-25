using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Addresses;

[JsonConverter(typeof(StringEnumSerializer<CreateAddressRequestAddressTypesItem>))]
[Serializable]
public readonly record struct CreateAddressRequestAddressTypesItem : IStringEnum
{
    public static readonly CreateAddressRequestAddressTypesItem Yard = new(Values.Yard);

    public static readonly CreateAddressRequestAddressTypesItem ShortHaul = new(Values.ShortHaul);

    public static readonly CreateAddressRequestAddressTypesItem WorkforceSite = new(
        Values.WorkforceSite
    );

    public static readonly CreateAddressRequestAddressTypesItem RiskZone = new(Values.RiskZone);

    public static readonly CreateAddressRequestAddressTypesItem IndustrialSite = new(
        Values.IndustrialSite
    );

    public static readonly CreateAddressRequestAddressTypesItem AlertsOnly = new(Values.AlertsOnly);

    public static readonly CreateAddressRequestAddressTypesItem AgricultureSource = new(
        Values.AgricultureSource
    );

    public static readonly CreateAddressRequestAddressTypesItem AvoidanceZone = new(
        Values.AvoidanceZone
    );

    public static readonly CreateAddressRequestAddressTypesItem KnownGpsJammingZone = new(
        Values.KnownGpsJammingZone
    );

    public static readonly CreateAddressRequestAddressTypesItem AuthorizedZone = new(
        Values.AuthorizedZone
    );

    public static readonly CreateAddressRequestAddressTypesItem UnauthorizedZone = new(
        Values.UnauthorizedZone
    );

    public static readonly CreateAddressRequestAddressTypesItem Vendor = new(Values.Vendor);

    public static readonly CreateAddressRequestAddressTypesItem Inventory = new(Values.Inventory);

    public CreateAddressRequestAddressTypesItem(string value)
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
    public static CreateAddressRequestAddressTypesItem FromCustom(string value)
    {
        return new CreateAddressRequestAddressTypesItem(value);
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

    public static bool operator ==(CreateAddressRequestAddressTypesItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateAddressRequestAddressTypesItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateAddressRequestAddressTypesItem value) =>
        value.Value;

    public static explicit operator CreateAddressRequestAddressTypesItem(string value) =>
        new(value);

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
