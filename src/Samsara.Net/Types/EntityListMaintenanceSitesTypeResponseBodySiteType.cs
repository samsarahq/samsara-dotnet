using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListMaintenanceSitesTypeResponseBodySiteType>))]
[Serializable]
public readonly record struct EntityListMaintenanceSitesTypeResponseBodySiteType : IStringEnum
{
    public static readonly EntityListMaintenanceSitesTypeResponseBodySiteType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListMaintenanceSitesTypeResponseBodySiteType CentralWarehouse =
        new(Values.CentralWarehouse);

    public static readonly EntityListMaintenanceSitesTypeResponseBodySiteType MaintenanceShop = new(
        Values.MaintenanceShop
    );

    public static readonly EntityListMaintenanceSitesTypeResponseBodySiteType MobileServiceVehicle =
        new(Values.MobileServiceVehicle);

    public static readonly EntityListMaintenanceSitesTypeResponseBodySiteType YardOnsite = new(
        Values.YardOnsite
    );

    public static readonly EntityListMaintenanceSitesTypeResponseBodySiteType Consignment = new(
        Values.Consignment
    );

    public static readonly EntityListMaintenanceSitesTypeResponseBodySiteType Other = new(
        Values.Other
    );

    public EntityListMaintenanceSitesTypeResponseBodySiteType(string value)
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
    public static EntityListMaintenanceSitesTypeResponseBodySiteType FromCustom(string value)
    {
        return new EntityListMaintenanceSitesTypeResponseBodySiteType(value);
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
        EntityListMaintenanceSitesTypeResponseBodySiteType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListMaintenanceSitesTypeResponseBodySiteType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListMaintenanceSitesTypeResponseBodySiteType value
    ) => value.Value;

    public static explicit operator EntityListMaintenanceSitesTypeResponseBodySiteType(
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
