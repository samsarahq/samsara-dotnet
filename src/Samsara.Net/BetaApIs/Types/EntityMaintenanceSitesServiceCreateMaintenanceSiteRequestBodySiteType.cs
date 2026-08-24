using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType>)
)]
[Serializable]
public readonly record struct EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType
    : IStringEnum
{
    public static readonly EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType Unknown =
        new(Values.Unknown);

    public static readonly EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType CentralWarehouse =
        new(Values.CentralWarehouse);

    public static readonly EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType MaintenanceShop =
        new(Values.MaintenanceShop);

    public static readonly EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType MobileServiceVehicle =
        new(Values.MobileServiceVehicle);

    public static readonly EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType YardOnsite =
        new(Values.YardOnsite);

    public static readonly EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType Consignment =
        new(Values.Consignment);

    public static readonly EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType Other =
        new(Values.Other);

    public EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType(string value)
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
    public static EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType FromCustom(
        string value
    )
    {
        return new EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType(value);
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
        EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType value
    ) => value.Value;

    public static explicit operator EntityMaintenanceSitesServiceCreateMaintenanceSiteRequestBodySiteType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string CentralWarehouse = "CentralWarehouse";

        public const string MaintenanceShop = "MaintenanceShop";

        public const string MobileServiceVehicle = "MobileServiceVehicle";

        public const string YardOnsite = "YardOnsite";

        public const string Consignment = "Consignment";

        public const string Other = "Other";
    }
}
