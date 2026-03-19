using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MissingStateResponseBodyUpdateSource>))]
[Serializable]
public readonly record struct MissingStateResponseBodyUpdateSource : IStringEnum
{
    public static readonly MissingStateResponseBodyUpdateSource Dashboard = new(Values.Dashboard);

    public static readonly MissingStateResponseBodyUpdateSource Api = new(Values.Api);

    public MissingStateResponseBodyUpdateSource(string value)
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
    public static MissingStateResponseBodyUpdateSource FromCustom(string value)
    {
        return new MissingStateResponseBodyUpdateSource(value);
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

    public static bool operator ==(MissingStateResponseBodyUpdateSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MissingStateResponseBodyUpdateSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MissingStateResponseBodyUpdateSource value) =>
        value.Value;

    public static explicit operator MissingStateResponseBodyUpdateSource(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Dashboard = "dashboard";

        public const string Api = "api";
    }
}
