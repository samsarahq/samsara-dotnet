using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UploadedMediaObjectResponseBodyCameraRole>))]
[Serializable]
public readonly record struct UploadedMediaObjectResponseBodyCameraRole : IStringEnum
{
    public static readonly UploadedMediaObjectResponseBodyCameraRole LeftMirrorMount = new(
        Values.LeftMirrorMount
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole LeftSide = new(
        Values.LeftSide
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole RightMirrorMount = new(
        Values.RightMirrorMount
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole RightSide = new(
        Values.RightSide
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole RearHigh = new(
        Values.RearHigh
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole RearBumper = new(
        Values.RearBumper
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole InCab = new(Values.InCab);

    public static readonly UploadedMediaObjectResponseBodyCameraRole Front = new(Values.Front);

    public static readonly UploadedMediaObjectResponseBodyCameraRole Hopper = new(Values.Hopper);

    public static readonly UploadedMediaObjectResponseBodyCameraRole Other1 = new(Values.Other1);

    public static readonly UploadedMediaObjectResponseBodyCameraRole Other2 = new(Values.Other2);

    public static readonly UploadedMediaObjectResponseBodyCameraRole Other3 = new(Values.Other3);

    public static readonly UploadedMediaObjectResponseBodyCameraRole Other4 = new(Values.Other4);

    public static readonly UploadedMediaObjectResponseBodyCameraRole LeftBev = new(Values.LeftBev);

    public static readonly UploadedMediaObjectResponseBodyCameraRole RightBev = new(
        Values.RightBev
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole RearBev = new(Values.RearBev);

    public static readonly UploadedMediaObjectResponseBodyCameraRole FrontBev = new(
        Values.FrontBev
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole OtherBev = new(
        Values.OtherBev
    );

    public static readonly UploadedMediaObjectResponseBodyCameraRole BevNotUsed = new(
        Values.BevNotUsed
    );

    public UploadedMediaObjectResponseBodyCameraRole(string value)
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
    public static UploadedMediaObjectResponseBodyCameraRole FromCustom(string value)
    {
        return new UploadedMediaObjectResponseBodyCameraRole(value);
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
        UploadedMediaObjectResponseBodyCameraRole value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UploadedMediaObjectResponseBodyCameraRole value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UploadedMediaObjectResponseBodyCameraRole value) =>
        value.Value;

    public static explicit operator UploadedMediaObjectResponseBodyCameraRole(string value) =>
        new(value);

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
