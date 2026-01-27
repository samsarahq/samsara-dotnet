using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<IdlingEventAddressObjectResponseBodyAddressTypesItem>))]
[Serializable]
public readonly record struct IdlingEventAddressObjectResponseBodyAddressTypesItem : IStringEnum
{
    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem AgricultureSource =
        new(Values.AgricultureSource);

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem AlertsOnly = new(
        Values.AlertsOnly
    );

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem AuthorizedZone =
        new(Values.AuthorizedZone);

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem AvoidanceZone = new(
        Values.AvoidanceZone
    );

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem IndustrialSite =
        new(Values.IndustrialSite);

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem KnownGpsJammingZone =
        new(Values.KnownGpsJammingZone);

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem RiskZone = new(
        Values.RiskZone
    );

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem ShortHaul = new(
        Values.ShortHaul
    );

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem UnauthorizedZone =
        new(Values.UnauthorizedZone);

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem Undefined = new(
        Values.Undefined
    );

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem WorkforceSite = new(
        Values.WorkforceSite
    );

    public static readonly IdlingEventAddressObjectResponseBodyAddressTypesItem Yard = new(
        Values.Yard
    );

    public IdlingEventAddressObjectResponseBodyAddressTypesItem(string value)
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
    public static IdlingEventAddressObjectResponseBodyAddressTypesItem FromCustom(string value)
    {
        return new IdlingEventAddressObjectResponseBodyAddressTypesItem(value);
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
        IdlingEventAddressObjectResponseBodyAddressTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IdlingEventAddressObjectResponseBodyAddressTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        IdlingEventAddressObjectResponseBodyAddressTypesItem value
    ) => value.Value;

    public static explicit operator IdlingEventAddressObjectResponseBodyAddressTypesItem(
        string value
    ) => new(value);

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
