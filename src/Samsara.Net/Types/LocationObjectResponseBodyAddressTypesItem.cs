using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<LocationObjectResponseBodyAddressTypesItem>))]
[Serializable]
public readonly record struct LocationObjectResponseBodyAddressTypesItem : IStringEnum
{
    public static readonly LocationObjectResponseBodyAddressTypesItem AgricultureSource = new(
        Values.AgricultureSource
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem AlertsOnly = new(
        Values.AlertsOnly
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem AuthorizedZone = new(
        Values.AuthorizedZone
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem AvoidanceZone = new(
        Values.AvoidanceZone
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem IndustrialSite = new(
        Values.IndustrialSite
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem Inventory = new(
        Values.Inventory
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem KnownGpsJammingZone = new(
        Values.KnownGpsJammingZone
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem RiskZone = new(
        Values.RiskZone
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem ShortHaul = new(
        Values.ShortHaul
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem UnauthorizedZone = new(
        Values.UnauthorizedZone
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem Undefined = new(
        Values.Undefined
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem Vendor = new(Values.Vendor);

    public static readonly LocationObjectResponseBodyAddressTypesItem WorkforceSite = new(
        Values.WorkforceSite
    );

    public static readonly LocationObjectResponseBodyAddressTypesItem Yard = new(Values.Yard);

    public LocationObjectResponseBodyAddressTypesItem(string value)
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
    public static LocationObjectResponseBodyAddressTypesItem FromCustom(string value)
    {
        return new LocationObjectResponseBodyAddressTypesItem(value);
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
        LocationObjectResponseBodyAddressTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LocationObjectResponseBodyAddressTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LocationObjectResponseBodyAddressTypesItem value) =>
        value.Value;

    public static explicit operator LocationObjectResponseBodyAddressTypesItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AgricultureSource = "agricultureSource";

        public const string AlertsOnly = "alertsOnly";

        public const string AuthorizedZone = "authorizedZone";

        public const string AvoidanceZone = "avoidanceZone";

        public const string IndustrialSite = "industrialSite";

        public const string Inventory = "inventory";

        public const string KnownGpsJammingZone = "knownGPSJammingZone";

        public const string RiskZone = "riskZone";

        public const string ShortHaul = "shortHaul";

        public const string UnauthorizedZone = "unauthorizedZone";

        public const string Undefined = "undefined";

        public const string Vendor = "vendor";

        public const string WorkforceSite = "workforceSite";

        public const string Yard = "yard";
    }
}
