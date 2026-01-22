using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LiveSharingLinks;

[JsonConverter(typeof(StringEnumSerializer<LiveSharingLinksCreateLiveSharingLinkRequestBodyType>))]
[Serializable]
public readonly record struct LiveSharingLinksCreateLiveSharingLinkRequestBodyType : IStringEnum
{
    public static readonly LiveSharingLinksCreateLiveSharingLinkRequestBodyType AssetsLocation =
        new(Values.AssetsLocation);

    public static readonly LiveSharingLinksCreateLiveSharingLinkRequestBodyType AssetsNearLocation =
        new(Values.AssetsNearLocation);

    public static readonly LiveSharingLinksCreateLiveSharingLinkRequestBodyType AssetsOnRoute = new(
        Values.AssetsOnRoute
    );

    public LiveSharingLinksCreateLiveSharingLinkRequestBodyType(string value)
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
    public static LiveSharingLinksCreateLiveSharingLinkRequestBodyType FromCustom(string value)
    {
        return new LiveSharingLinksCreateLiveSharingLinkRequestBodyType(value);
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
        LiveSharingLinksCreateLiveSharingLinkRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        LiveSharingLinksCreateLiveSharingLinkRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        LiveSharingLinksCreateLiveSharingLinkRequestBodyType value
    ) => value.Value;

    public static explicit operator LiveSharingLinksCreateLiveSharingLinkRequestBodyType(
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
