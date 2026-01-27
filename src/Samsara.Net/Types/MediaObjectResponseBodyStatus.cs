using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MediaObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct MediaObjectResponseBodyStatus : IStringEnum
{
    public static readonly MediaObjectResponseBodyStatus Available = new(Values.Available);

    public static readonly MediaObjectResponseBodyStatus Invalid = new(Values.Invalid);

    public static readonly MediaObjectResponseBodyStatus Pending = new(Values.Pending);

    public static readonly MediaObjectResponseBodyStatus Failed = new(Values.Failed);

    public static readonly MediaObjectResponseBodyStatus Unavailable = new(Values.Unavailable);

    public MediaObjectResponseBodyStatus(string value)
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
    public static MediaObjectResponseBodyStatus FromCustom(string value)
    {
        return new MediaObjectResponseBodyStatus(value);
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

    public static bool operator ==(MediaObjectResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MediaObjectResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MediaObjectResponseBodyStatus value) => value.Value;

    public static explicit operator MediaObjectResponseBodyStatus(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Available = "available";

        public const string Invalid = "invalid";

        public const string Pending = "pending";

        public const string Failed = "failed";

        public const string Unavailable = "unavailable";
    }
}
