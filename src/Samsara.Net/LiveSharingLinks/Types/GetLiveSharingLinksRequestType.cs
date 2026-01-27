using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LiveSharingLinks;

[JsonConverter(typeof(StringEnumSerializer<GetLiveSharingLinksRequestType>))]
[Serializable]
public readonly record struct GetLiveSharingLinksRequestType : IStringEnum
{
    public static readonly GetLiveSharingLinksRequestType All = new(Values.All);

    public static readonly GetLiveSharingLinksRequestType AssetsLocation = new(
        Values.AssetsLocation
    );

    public static readonly GetLiveSharingLinksRequestType AssetsNearLocation = new(
        Values.AssetsNearLocation
    );

    public static readonly GetLiveSharingLinksRequestType AssetsOnRoute = new(Values.AssetsOnRoute);

    public GetLiveSharingLinksRequestType(string value)
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
    public static GetLiveSharingLinksRequestType FromCustom(string value)
    {
        return new GetLiveSharingLinksRequestType(value);
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

    public static bool operator ==(GetLiveSharingLinksRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetLiveSharingLinksRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetLiveSharingLinksRequestType value) => value.Value;

    public static explicit operator GetLiveSharingLinksRequestType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string All = "all";

        public const string AssetsLocation = "assetsLocation";

        public const string AssetsNearLocation = "assetsNearLocation";

        public const string AssetsOnRoute = "assetsOnRoute";
    }
}
