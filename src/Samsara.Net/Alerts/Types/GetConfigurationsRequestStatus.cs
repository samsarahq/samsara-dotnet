using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

[JsonConverter(typeof(StringEnumSerializer<GetConfigurationsRequestStatus>))]
[Serializable]
public readonly record struct GetConfigurationsRequestStatus : IStringEnum
{
    public static readonly GetConfigurationsRequestStatus All = new(Values.All);

    public static readonly GetConfigurationsRequestStatus Enabled = new(Values.Enabled);

    public static readonly GetConfigurationsRequestStatus Disabled = new(Values.Disabled);

    public GetConfigurationsRequestStatus(string value)
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
    public static GetConfigurationsRequestStatus FromCustom(string value)
    {
        return new GetConfigurationsRequestStatus(value);
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

    public static bool operator ==(GetConfigurationsRequestStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetConfigurationsRequestStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetConfigurationsRequestStatus value) => value.Value;

    public static explicit operator GetConfigurationsRequestStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string All = "all";

        public const string Enabled = "enabled";

        public const string Disabled = "disabled";
    }
}
