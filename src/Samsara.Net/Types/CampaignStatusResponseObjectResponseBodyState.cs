using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignStatusResponseObjectResponseBodyState>))]
[Serializable]
public readonly record struct CampaignStatusResponseObjectResponseBodyState : IStringEnum
{
    public static readonly CampaignStatusResponseObjectResponseBodyState Draft = new(Values.Draft);

    public static readonly CampaignStatusResponseObjectResponseBodyState Active = new(
        Values.Active
    );

    public static readonly CampaignStatusResponseObjectResponseBodyState OnHold = new(
        Values.OnHold
    );

    public static readonly CampaignStatusResponseObjectResponseBodyState Complete = new(
        Values.Complete
    );

    public static readonly CampaignStatusResponseObjectResponseBodyState Cancelled = new(
        Values.Cancelled
    );

    public static readonly CampaignStatusResponseObjectResponseBodyState Unknown = new(
        Values.Unknown
    );

    public CampaignStatusResponseObjectResponseBodyState(string value)
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
    public static CampaignStatusResponseObjectResponseBodyState FromCustom(string value)
    {
        return new CampaignStatusResponseObjectResponseBodyState(value);
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
        CampaignStatusResponseObjectResponseBodyState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignStatusResponseObjectResponseBodyState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CampaignStatusResponseObjectResponseBodyState value) =>
        value.Value;

    public static explicit operator CampaignStatusResponseObjectResponseBodyState(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Draft = "draft";

        public const string Active = "active";

        public const string OnHold = "onHold";

        public const string Complete = "complete";

        public const string Cancelled = "cancelled";

        public const string Unknown = "unknown";
    }
}
