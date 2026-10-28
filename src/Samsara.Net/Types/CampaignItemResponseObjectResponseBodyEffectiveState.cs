using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignItemResponseObjectResponseBodyEffectiveState>))]
[Serializable]
public readonly record struct CampaignItemResponseObjectResponseBodyEffectiveState : IStringEnum
{
    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Pending = new(
        Values.Pending
    );

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Hold = new(
        Values.Hold
    );

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Ready = new(
        Values.Ready
    );

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState WorkOrderCreated =
        new(Values.WorkOrderCreated);

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Complete = new(
        Values.Complete
    );

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Dismissed = new(
        Values.Dismissed
    );

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Cancelled = new(
        Values.Cancelled
    );

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Suspended = new(
        Values.Suspended
    );

    public static readonly CampaignItemResponseObjectResponseBodyEffectiveState Unknown = new(
        Values.Unknown
    );

    public CampaignItemResponseObjectResponseBodyEffectiveState(string value)
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
    public static CampaignItemResponseObjectResponseBodyEffectiveState FromCustom(string value)
    {
        return new CampaignItemResponseObjectResponseBodyEffectiveState(value);
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
        CampaignItemResponseObjectResponseBodyEffectiveState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignItemResponseObjectResponseBodyEffectiveState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignItemResponseObjectResponseBodyEffectiveState value
    ) => value.Value;

    public static explicit operator CampaignItemResponseObjectResponseBodyEffectiveState(
        string value
    ) => new(value);

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

        public const string Suspended = "suspended";

        public const string Unknown = "unknown";
    }
}
