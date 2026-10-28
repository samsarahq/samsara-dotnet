using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<CampaignsPostCampaignsRequestBodyWorkOrderPriority>))]
[Serializable]
public readonly record struct CampaignsPostCampaignsRequestBodyWorkOrderPriority : IStringEnum
{
    public static readonly CampaignsPostCampaignsRequestBodyWorkOrderPriority High = new(
        Values.High
    );

    public static readonly CampaignsPostCampaignsRequestBodyWorkOrderPriority Low = new(Values.Low);

    public static readonly CampaignsPostCampaignsRequestBodyWorkOrderPriority Medium = new(
        Values.Medium
    );

    public static readonly CampaignsPostCampaignsRequestBodyWorkOrderPriority Urgent = new(
        Values.Urgent
    );

    public CampaignsPostCampaignsRequestBodyWorkOrderPriority(string value)
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
    public static CampaignsPostCampaignsRequestBodyWorkOrderPriority FromCustom(string value)
    {
        return new CampaignsPostCampaignsRequestBodyWorkOrderPriority(value);
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
        CampaignsPostCampaignsRequestBodyWorkOrderPriority value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignsPostCampaignsRequestBodyWorkOrderPriority value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignsPostCampaignsRequestBodyWorkOrderPriority value
    ) => value.Value;

    public static explicit operator CampaignsPostCampaignsRequestBodyWorkOrderPriority(
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
