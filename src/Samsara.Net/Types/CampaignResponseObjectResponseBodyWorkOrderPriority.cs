using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignResponseObjectResponseBodyWorkOrderPriority>))]
[Serializable]
public readonly record struct CampaignResponseObjectResponseBodyWorkOrderPriority : IStringEnum
{
    public static readonly CampaignResponseObjectResponseBodyWorkOrderPriority High = new(
        Values.High
    );

    public static readonly CampaignResponseObjectResponseBodyWorkOrderPriority Low = new(
        Values.Low
    );

    public static readonly CampaignResponseObjectResponseBodyWorkOrderPriority Medium = new(
        Values.Medium
    );

    public static readonly CampaignResponseObjectResponseBodyWorkOrderPriority Urgent = new(
        Values.Urgent
    );

    public CampaignResponseObjectResponseBodyWorkOrderPriority(string value)
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
    public static CampaignResponseObjectResponseBodyWorkOrderPriority FromCustom(string value)
    {
        return new CampaignResponseObjectResponseBodyWorkOrderPriority(value);
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
        CampaignResponseObjectResponseBodyWorkOrderPriority value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignResponseObjectResponseBodyWorkOrderPriority value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignResponseObjectResponseBodyWorkOrderPriority value
    ) => value.Value;

    public static explicit operator CampaignResponseObjectResponseBodyWorkOrderPriority(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string High = "High";

        public const string Low = "Low";

        public const string Medium = "Medium";

        public const string Urgent = "Urgent";
    }
}
