using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RouteFeedObjectResponseBodySource>))]
[Serializable]
public readonly record struct RouteFeedObjectResponseBodySource : IStringEnum
{
    public static readonly RouteFeedObjectResponseBodySource Automatic = new(Values.Automatic);

    public static readonly RouteFeedObjectResponseBodySource Driver = new(Values.Driver);

    public static readonly RouteFeedObjectResponseBodySource Admin = new(Values.Admin);

    public RouteFeedObjectResponseBodySource(string value)
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
    public static RouteFeedObjectResponseBodySource FromCustom(string value)
    {
        return new RouteFeedObjectResponseBodySource(value);
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

    public static bool operator ==(RouteFeedObjectResponseBodySource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RouteFeedObjectResponseBodySource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RouteFeedObjectResponseBodySource value) => value.Value;

    public static explicit operator RouteFeedObjectResponseBodySource(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Automatic = "automatic";

        public const string Driver = "driver";

        public const string Admin = "admin";
    }
}
