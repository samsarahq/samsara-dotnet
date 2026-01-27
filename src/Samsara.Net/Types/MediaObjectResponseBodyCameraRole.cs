using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MediaObjectResponseBodyCameraRole>))]
[Serializable]
public readonly record struct MediaObjectResponseBodyCameraRole : IStringEnum
{
    public static readonly MediaObjectResponseBodyCameraRole LeftMirrorMount = new(
        Values.LeftMirrorMount
    );

    public static readonly MediaObjectResponseBodyCameraRole LeftSide = new(Values.LeftSide);

    public static readonly MediaObjectResponseBodyCameraRole RightMirrorMount = new(
        Values.RightMirrorMount
    );

    public static readonly MediaObjectResponseBodyCameraRole RightSide = new(Values.RightSide);

    public static readonly MediaObjectResponseBodyCameraRole RearHigh = new(Values.RearHigh);

    public static readonly MediaObjectResponseBodyCameraRole RearBumper = new(Values.RearBumper);

    public static readonly MediaObjectResponseBodyCameraRole InCab = new(Values.InCab);

    public static readonly MediaObjectResponseBodyCameraRole Front = new(Values.Front);

    public static readonly MediaObjectResponseBodyCameraRole Hopper = new(Values.Hopper);

    public static readonly MediaObjectResponseBodyCameraRole Other1 = new(Values.Other1);

    public static readonly MediaObjectResponseBodyCameraRole Other2 = new(Values.Other2);

    public static readonly MediaObjectResponseBodyCameraRole Other3 = new(Values.Other3);

    public static readonly MediaObjectResponseBodyCameraRole Other4 = new(Values.Other4);

    public static readonly MediaObjectResponseBodyCameraRole LeftBev = new(Values.LeftBev);

    public static readonly MediaObjectResponseBodyCameraRole RightBev = new(Values.RightBev);

    public static readonly MediaObjectResponseBodyCameraRole RearBev = new(Values.RearBev);

    public static readonly MediaObjectResponseBodyCameraRole FrontBev = new(Values.FrontBev);

    public static readonly MediaObjectResponseBodyCameraRole OtherBev = new(Values.OtherBev);

    public static readonly MediaObjectResponseBodyCameraRole BevNotUsed = new(Values.BevNotUsed);

    public MediaObjectResponseBodyCameraRole(string value)
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
    public static MediaObjectResponseBodyCameraRole FromCustom(string value)
    {
        return new MediaObjectResponseBodyCameraRole(value);
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

    public static bool operator ==(MediaObjectResponseBodyCameraRole value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MediaObjectResponseBodyCameraRole value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MediaObjectResponseBodyCameraRole value) => value.Value;

    public static explicit operator MediaObjectResponseBodyCameraRole(string value) => new(value);

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
