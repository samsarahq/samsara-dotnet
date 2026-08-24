using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateMaintenanceSiteTypeResponseBodySiteType>))]
[Serializable]
public readonly record struct EntityCreateMaintenanceSiteTypeResponseBodySiteType : IStringEnum
{
    public static readonly EntityCreateMaintenanceSiteTypeResponseBodySiteType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreateMaintenanceSiteTypeResponseBodySiteType CentralWarehouse =
        new(Values.CentralWarehouse);

    public static readonly EntityCreateMaintenanceSiteTypeResponseBodySiteType MaintenanceShop =
        new(Values.MaintenanceShop);

    public static readonly EntityCreateMaintenanceSiteTypeResponseBodySiteType MobileServiceVehicle =
        new(Values.MobileServiceVehicle);

    public static readonly EntityCreateMaintenanceSiteTypeResponseBodySiteType YardOnsite = new(
        Values.YardOnsite
    );

    public static readonly EntityCreateMaintenanceSiteTypeResponseBodySiteType Consignment = new(
        Values.Consignment
    );

    public static readonly EntityCreateMaintenanceSiteTypeResponseBodySiteType Other = new(
        Values.Other
    );

    public EntityCreateMaintenanceSiteTypeResponseBodySiteType(string value)
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
    public static EntityCreateMaintenanceSiteTypeResponseBodySiteType FromCustom(string value)
    {
        return new EntityCreateMaintenanceSiteTypeResponseBodySiteType(value);
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
        EntityCreateMaintenanceSiteTypeResponseBodySiteType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateMaintenanceSiteTypeResponseBodySiteType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreateMaintenanceSiteTypeResponseBodySiteType value
    ) => value.Value;

    public static explicit operator EntityCreateMaintenanceSiteTypeResponseBodySiteType(
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
