using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CampaignResponseObjectResponseBodyCreatedSource>))]
[Serializable]
public readonly record struct CampaignResponseObjectResponseBodyCreatedSource : IStringEnum
{
    public static readonly CampaignResponseObjectResponseBodyCreatedSource Dashboard = new(
        Values.Dashboard
    );

    public static readonly CampaignResponseObjectResponseBodyCreatedSource Api = new(Values.Api);

    public static readonly CampaignResponseObjectResponseBodyCreatedSource Assistant = new(
        Values.Assistant
    );

    public static readonly CampaignResponseObjectResponseBodyCreatedSource Unknown = new(
        Values.Unknown
    );

    public CampaignResponseObjectResponseBodyCreatedSource(string value)
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
    public static CampaignResponseObjectResponseBodyCreatedSource FromCustom(string value)
    {
        return new CampaignResponseObjectResponseBodyCreatedSource(value);
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
        CampaignResponseObjectResponseBodyCreatedSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CampaignResponseObjectResponseBodyCreatedSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CampaignResponseObjectResponseBodyCreatedSource value) =>
        value.Value;

    public static explicit operator CampaignResponseObjectResponseBodyCreatedSource(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Dashboard = "dashboard";

        public const string Api = "api";

        public const string Assistant = "assistant";

        public const string Unknown = "unknown";
    }
}
