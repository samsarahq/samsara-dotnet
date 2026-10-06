using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus>)
)]
[Serializable]
public readonly record struct EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus
    : IStringEnum
{
    public static readonly EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus Unknown =
        new(Values.Unknown);

    public static readonly EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus Overdue =
        new(Values.Overdue);

    public static readonly EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus Upcoming =
        new(Values.Upcoming);

    public EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus(string value)
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
    public static EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus FromCustom(
        string value
    )
    {
        return new EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus(value);
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
        EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus value
    ) => value.Value;

    public static explicit operator EntityUpdateUpcomingPreventiveMaintenanceTypeResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Overdue = "overdue";

        public const string Upcoming = "upcoming";
    }
}
