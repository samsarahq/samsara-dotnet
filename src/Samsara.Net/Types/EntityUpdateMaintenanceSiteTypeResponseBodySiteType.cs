using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdateMaintenanceSiteTypeResponseBodySiteType>))]
[Serializable]
public readonly record struct EntityUpdateMaintenanceSiteTypeResponseBodySiteType : IStringEnum
{
    public static readonly EntityUpdateMaintenanceSiteTypeResponseBodySiteType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityUpdateMaintenanceSiteTypeResponseBodySiteType CentralWarehouse =
        new(Values.CentralWarehouse);

    public static readonly EntityUpdateMaintenanceSiteTypeResponseBodySiteType MaintenanceShop =
        new(Values.MaintenanceShop);

    public static readonly EntityUpdateMaintenanceSiteTypeResponseBodySiteType MobileServiceVehicle =
        new(Values.MobileServiceVehicle);

    public static readonly EntityUpdateMaintenanceSiteTypeResponseBodySiteType YardOnsite = new(
        Values.YardOnsite
    );

    public static readonly EntityUpdateMaintenanceSiteTypeResponseBodySiteType Consignment = new(
        Values.Consignment
    );

    public static readonly EntityUpdateMaintenanceSiteTypeResponseBodySiteType Other = new(
        Values.Other
    );

    public EntityUpdateMaintenanceSiteTypeResponseBodySiteType(string value)
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
    public static EntityUpdateMaintenanceSiteTypeResponseBodySiteType FromCustom(string value)
    {
        return new EntityUpdateMaintenanceSiteTypeResponseBodySiteType(value);
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
        EntityUpdateMaintenanceSiteTypeResponseBodySiteType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateMaintenanceSiteTypeResponseBodySiteType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdateMaintenanceSiteTypeResponseBodySiteType value
    ) => value.Value;

    public static explicit operator EntityUpdateMaintenanceSiteTypeResponseBodySiteType(
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
