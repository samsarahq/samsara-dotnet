using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignItemResponseObjectResponseBodyState>))]
[Serializable]
public readonly record struct CampaignItemResponseObjectResponseBodyState : IStringEnum
{
    public static readonly CampaignItemResponseObjectResponseBodyState Pending = new(
        Values.Pending
    );

    public static readonly CampaignItemResponseObjectResponseBodyState Hold = new(Values.Hold);

    public static readonly CampaignItemResponseObjectResponseBodyState Ready = new(Values.Ready);

    public static readonly CampaignItemResponseObjectResponseBodyState WorkOrderCreated = new(
        Values.WorkOrderCreated
    );

    public static readonly CampaignItemResponseObjectResponseBodyState Complete = new(
        Values.Complete
    );

    public static readonly CampaignItemResponseObjectResponseBodyState Dismissed = new(
        Values.Dismissed
    );

    public static readonly CampaignItemResponseObjectResponseBodyState Cancelled = new(
        Values.Cancelled
    );

    public static readonly CampaignItemResponseObjectResponseBodyState Unknown = new(
        Values.Unknown
    );

    public CampaignItemResponseObjectResponseBodyState(string value)
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
    public static CampaignItemResponseObjectResponseBodyState FromCustom(string value)
    {
        return new CampaignItemResponseObjectResponseBodyState(value);
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
        CampaignItemResponseObjectResponseBodyState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignItemResponseObjectResponseBodyState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CampaignItemResponseObjectResponseBodyState value) =>
        value.Value;

    public static explicit operator CampaignItemResponseObjectResponseBodyState(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "pending";

        public const string Hold = "hold";

        public const string Ready = "ready";

        public const string WorkOrderCreated = "workOrderCreated";

        public const string Complete = "complete";

        public const string Dismissed = "dismissed";

        public const string Cancelled = "cancelled";

        public const string Unknown = "unknown";
    }
}
