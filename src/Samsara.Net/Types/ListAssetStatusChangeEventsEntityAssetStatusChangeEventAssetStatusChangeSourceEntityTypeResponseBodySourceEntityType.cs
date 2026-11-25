using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType>)
)]
[Serializable]
public readonly record struct ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType
    : IStringEnum
{
    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType Unknown =
        new(Values.Unknown);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType WorkOrder =
        new(Values.WorkOrder);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType CampaignItem =
        new(Values.CampaignItem);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType AutomationRule =
        new(Values.AutomationRule);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType Geofence =
        new(Values.Geofence);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType Dvir =
        new(Values.Dvir);

    public static readonly ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType CsvUpload =
        new(Values.CsvUpload);

    public ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType(
        string value
    )
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
    public static ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType FromCustom(
        string value
    )
    {
        return new ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType(
            value
        );
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
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType value
    ) => value.Value;

    public static explicit operator ListAssetStatusChangeEventsEntityAssetStatusChangeEventAssetStatusChangeSourceEntityTypeResponseBodySourceEntityType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string WorkOrder = "workOrder";

        public const string CampaignItem = "campaignItem";

        public const string AutomationRule = "automationRule";

        public const string Geofence = "geofence";

        public const string Dvir = "dvir";

        public const string CsvUpload = "csvUpload";
    }
}
