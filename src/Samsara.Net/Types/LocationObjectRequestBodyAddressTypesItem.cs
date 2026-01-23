using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<LocationObjectRequestBodyAddressTypesItem>))]
[Serializable]
public readonly record struct LocationObjectRequestBodyAddressTypesItem : IStringEnum
{
    public static readonly LocationObjectRequestBodyAddressTypesItem AgricultureSource = new(
        Values.AgricultureSource
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem AlertsOnly = new(
        Values.AlertsOnly
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem AuthorizedZone = new(
        Values.AuthorizedZone
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem AvoidanceZone = new(
        Values.AvoidanceZone
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem IndustrialSite = new(
        Values.IndustrialSite
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem KnownGpsJammingZone = new(
        Values.KnownGpsJammingZone
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem RiskZone = new(
        Values.RiskZone
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem ShortHaul = new(
        Values.ShortHaul
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem UnauthorizedZone = new(
        Values.UnauthorizedZone
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem Undefined = new(
        Values.Undefined
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem WorkforceSite = new(
        Values.WorkforceSite
    );

    public static readonly LocationObjectRequestBodyAddressTypesItem Yard = new(Values.Yard);

    public LocationObjectRequestBodyAddressTypesItem(string value)
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
    public static LocationObjectRequestBodyAddressTypesItem FromCustom(string value)
    {
        return new LocationObjectRequestBodyAddressTypesItem(value);
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
        LocationObjectRequestBodyAddressTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LocationObjectRequestBodyAddressTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(LocationObjectRequestBodyAddressTypesItem value) =>
        value.Value;

    public static explicit operator LocationObjectRequestBodyAddressTypesItem(string value) =>
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

        public const string KnownGpsJammingZone = "knownGPSJammingZone";

        public const string RiskZone = "riskZone";

        public const string ShortHaul = "shortHaul";

        public const string UnauthorizedZone = "unauthorizedZone";

        public const string Undefined = "undefined";

        public const string WorkforceSite = "workforceSite";

        public const string Yard = "yard";
    }
}
