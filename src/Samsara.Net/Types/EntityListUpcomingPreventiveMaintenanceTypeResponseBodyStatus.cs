using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus>)
)]
[Serializable]
public readonly record struct EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus
    : IStringEnum
{
    public static readonly EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus Unknown =
        new(Values.Unknown);

    public static readonly EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus Overdue =
        new(Values.Overdue);

    public static readonly EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus Upcoming =
        new(Values.Upcoming);

    public EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus(string value)
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
    public static EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus FromCustom(
        string value
    )
    {
        return new EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus(value);
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
        EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus value
    ) => value.Value;

    public static explicit operator EntityListUpcomingPreventiveMaintenanceTypeResponseBodyStatus(
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
