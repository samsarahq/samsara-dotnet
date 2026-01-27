using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Routes;

[JsonConverter(typeof(StringEnumSerializer<GetRoutesFeedRequestExpand>))]
[Serializable]
public readonly record struct GetRoutesFeedRequestExpand : IStringEnum
{
    public static readonly GetRoutesFeedRequestExpand Route = new(Values.Route);

    public GetRoutesFeedRequestExpand(string value)
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
    public static GetRoutesFeedRequestExpand FromCustom(string value)
    {
        return new GetRoutesFeedRequestExpand(value);
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

    public static bool operator ==(GetRoutesFeedRequestExpand value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetRoutesFeedRequestExpand value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetRoutesFeedRequestExpand value) => value.Value;

    public static explicit operator GetRoutesFeedRequestExpand(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Route = "route";
    }
}
