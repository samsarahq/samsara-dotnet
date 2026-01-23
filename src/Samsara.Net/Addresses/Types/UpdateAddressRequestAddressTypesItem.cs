using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Addresses;

[JsonConverter(typeof(StringEnumSerializer<UpdateAddressRequestAddressTypesItem>))]
[Serializable]
public readonly record struct UpdateAddressRequestAddressTypesItem : IStringEnum
{
    public static readonly UpdateAddressRequestAddressTypesItem Yard = new(Values.Yard);

    public static readonly UpdateAddressRequestAddressTypesItem ShortHaul = new(Values.ShortHaul);

    public static readonly UpdateAddressRequestAddressTypesItem WorkforceSite = new(
        Values.WorkforceSite
    );

    public static readonly UpdateAddressRequestAddressTypesItem RiskZone = new(Values.RiskZone);

    public static readonly UpdateAddressRequestAddressTypesItem IndustrialSite = new(
        Values.IndustrialSite
    );

    public static readonly UpdateAddressRequestAddressTypesItem AlertsOnly = new(Values.AlertsOnly);

    public static readonly UpdateAddressRequestAddressTypesItem AgricultureSource = new(
        Values.AgricultureSource
    );

    public static readonly UpdateAddressRequestAddressTypesItem AvoidanceZone = new(
        Values.AvoidanceZone
    );

    public static readonly UpdateAddressRequestAddressTypesItem KnownGpsJammingZone = new(
        Values.KnownGpsJammingZone
    );

    public static readonly UpdateAddressRequestAddressTypesItem AuthorizedZone = new(
        Values.AuthorizedZone
    );

    public static readonly UpdateAddressRequestAddressTypesItem UnauthorizedZone = new(
        Values.UnauthorizedZone
    );

    public UpdateAddressRequestAddressTypesItem(string value)
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
    public static UpdateAddressRequestAddressTypesItem FromCustom(string value)
    {
        return new UpdateAddressRequestAddressTypesItem(value);
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

    public static bool operator ==(UpdateAddressRequestAddressTypesItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateAddressRequestAddressTypesItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateAddressRequestAddressTypesItem value) =>
        value.Value;

    public static explicit operator UpdateAddressRequestAddressTypesItem(string value) =>
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
    }
}
