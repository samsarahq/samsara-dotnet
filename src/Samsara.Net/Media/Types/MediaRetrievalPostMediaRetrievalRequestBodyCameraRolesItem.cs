using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Media;

[JsonConverter(
    typeof(StringEnumSerializer<MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem>)
)]
[Serializable]
public readonly record struct MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem
    : IStringEnum
{
    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem LeftMirrorMount =
        new(Values.LeftMirrorMount);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem LeftSide =
        new(Values.LeftSide);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem RightMirrorMount =
        new(Values.RightMirrorMount);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem RightSide =
        new(Values.RightSide);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem RearHigh =
        new(Values.RearHigh);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem RearBumper =
        new(Values.RearBumper);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem InCab = new(
        Values.InCab
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem Front = new(
        Values.Front
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem Hopper = new(
        Values.Hopper
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem Other1 = new(
        Values.Other1
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem Other2 = new(
        Values.Other2
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem Other3 = new(
        Values.Other3
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem Other4 = new(
        Values.Other4
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem LeftBev = new(
        Values.LeftBev
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem RightBev =
        new(Values.RightBev);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem RearBev = new(
        Values.RearBev
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem FrontBev =
        new(Values.FrontBev);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem OtherBev =
        new(Values.OtherBev);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem BevNotUsed =
        new(Values.BevNotUsed);

    public MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem(string value)
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
    public static MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem FromCustom(
        string value
    )
    {
        return new MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem(value);
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
        MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem value
    ) => value.Value;

    public static explicit operator MediaRetrievalPostMediaRetrievalRequestBodyCameraRolesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string LeftMirrorMount = "leftMirrorMount";

        public const string LeftSide = "leftSide";

        public const string RightMirrorMount = "rightMirrorMount";

        public const string RightSide = "rightSide";

        public const string RearHigh = "rearHigh";

        public const string RearBumper = "rearBumper";

        public const string InCab = "inCab";

        public const string Front = "front";

        public const string Hopper = "hopper";

        public const string Other1 = "other1";

        public const string Other2 = "other2";

        public const string Other3 = "other3";

        public const string Other4 = "other4";

        public const string LeftBev = "leftBev";

        public const string RightBev = "rightBev";

        public const string RearBev = "rearBev";

        public const string FrontBev = "frontBev";

        public const string OtherBev = "otherBev";

        public const string BevNotUsed = "bevNotUsed";
    }
}
