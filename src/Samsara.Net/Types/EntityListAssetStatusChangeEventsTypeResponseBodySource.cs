using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityListAssetStatusChangeEventsTypeResponseBodySource>)
)]
[Serializable]
public readonly record struct EntityListAssetStatusChangeEventsTypeResponseBodySource : IStringEnum
{
    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Dashboard = new(
        Values.Dashboard
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Csv = new(
        Values.Csv
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Automation = new(
        Values.Automation
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Api = new(
        Values.Api
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Mobile = new(
        Values.Mobile
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Shim = new(
        Values.Shim
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource Backfill = new(
        Values.Backfill
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource System = new(
        Values.System
    );

    public static readonly EntityListAssetStatusChangeEventsTypeResponseBodySource CsvHistoricalImport =
        new(Values.CsvHistoricalImport);

    public EntityListAssetStatusChangeEventsTypeResponseBodySource(string value)
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
    public static EntityListAssetStatusChangeEventsTypeResponseBodySource FromCustom(string value)
    {
        return new EntityListAssetStatusChangeEventsTypeResponseBodySource(value);
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
        EntityListAssetStatusChangeEventsTypeResponseBodySource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListAssetStatusChangeEventsTypeResponseBodySource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListAssetStatusChangeEventsTypeResponseBodySource value
    ) => value.Value;

    public static explicit operator EntityListAssetStatusChangeEventsTypeResponseBodySource(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Dashboard = "dashboard";

        public const string Csv = "csv";

        public const string Automation = "automation";

        public const string Api = "api";

        public const string Mobile = "mobile";

        public const string Shim = "shim";

        public const string Backfill = "backfill";

        public const string System = "system";

        public const string CsvHistoricalImport = "csvHistoricalImport";
    }
}
