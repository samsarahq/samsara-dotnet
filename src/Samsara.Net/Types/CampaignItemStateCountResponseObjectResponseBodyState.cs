using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignItemStateCountResponseObjectResponseBodyState>))]
[Serializable]
public readonly record struct CampaignItemStateCountResponseObjectResponseBodyState : IStringEnum
{
    public static readonly CampaignItemStateCountResponseObjectResponseBodyState Pending = new(
        Values.Pending
    );

    public static readonly CampaignItemStateCountResponseObjectResponseBodyState Hold = new(
        Values.Hold
    );

    public static readonly CampaignItemStateCountResponseObjectResponseBodyState Ready = new(
        Values.Ready
    );

    public static readonly CampaignItemStateCountResponseObjectResponseBodyState WorkOrderCreated =
        new(Values.WorkOrderCreated);

    public static readonly CampaignItemStateCountResponseObjectResponseBodyState Complete = new(
        Values.Complete
    );

    public static readonly CampaignItemStateCountResponseObjectResponseBodyState Dismissed = new(
        Values.Dismissed
    );

    public static readonly CampaignItemStateCountResponseObjectResponseBodyState Cancelled = new(
        Values.Cancelled
    );

    public static readonly CampaignItemStateCountResponseObjectResponseBodyState Unknown = new(
        Values.Unknown
    );

    public CampaignItemStateCountResponseObjectResponseBodyState(string value)
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
    public static CampaignItemStateCountResponseObjectResponseBodyState FromCustom(string value)
    {
        return new CampaignItemStateCountResponseObjectResponseBodyState(value);
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
        CampaignItemStateCountResponseObjectResponseBodyState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignItemStateCountResponseObjectResponseBodyState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CampaignItemStateCountResponseObjectResponseBodyState value
    ) => value.Value;

    public static explicit operator CampaignItemStateCountResponseObjectResponseBodyState(
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

        public const string Unknown = "unknown";
    }
}
