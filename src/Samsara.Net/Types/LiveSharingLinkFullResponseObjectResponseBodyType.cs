using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<LiveSharingLinkFullResponseObjectResponseBodyType>))]
[Serializable]
public readonly record struct LiveSharingLinkFullResponseObjectResponseBodyType : IStringEnum
{
    public static readonly LiveSharingLinkFullResponseObjectResponseBodyType AssetsLocation = new(
        Values.AssetsLocation
    );

    public static readonly LiveSharingLinkFullResponseObjectResponseBodyType AssetsNearLocation =
        new(Values.AssetsNearLocation);

    public static readonly LiveSharingLinkFullResponseObjectResponseBodyType AssetsOnRoute = new(
        Values.AssetsOnRoute
    );

    public LiveSharingLinkFullResponseObjectResponseBodyType(string value)
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
    public static LiveSharingLinkFullResponseObjectResponseBodyType FromCustom(string value)
    {
        return new LiveSharingLinkFullResponseObjectResponseBodyType(value);
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
        LiveSharingLinkFullResponseObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LiveSharingLinkFullResponseObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        LiveSharingLinkFullResponseObjectResponseBodyType value
    ) => value.Value;

    public static explicit operator LiveSharingLinkFullResponseObjectResponseBodyType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AssetsLocation = "assetsLocation";

        public const string AssetsNearLocation = "assetsNearLocation";

        public const string AssetsOnRoute = "assetsOnRoute";
    }
}
