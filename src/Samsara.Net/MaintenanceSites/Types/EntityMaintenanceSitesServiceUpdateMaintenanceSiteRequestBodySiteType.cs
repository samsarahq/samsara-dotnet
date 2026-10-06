using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.MaintenanceSites;

[JsonConverter(
    typeof(StringEnumSerializer<EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType>)
)]
[Serializable]
public readonly record struct EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType
    : IStringEnum
{
    public static readonly EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType Unknown =
        new(Values.Unknown);

    public static readonly EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType CentralWarehouse =
        new(Values.CentralWarehouse);

    public static readonly EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType MaintenanceShop =
        new(Values.MaintenanceShop);

    public static readonly EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType MobileServiceVehicle =
        new(Values.MobileServiceVehicle);

    public static readonly EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType YardOnsite =
        new(Values.YardOnsite);

    public static readonly EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType Consignment =
        new(Values.Consignment);

    public static readonly EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType Other =
        new(Values.Other);

    public EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType(string value)
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
    public static EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType FromCustom(
        string value
    )
    {
        return new EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType(value);
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
        EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType value
    ) => value.Value;

    public static explicit operator EntityMaintenanceSitesServiceUpdateMaintenanceSiteRequestBodySiteType(
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
