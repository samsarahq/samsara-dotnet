using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventV2MediaResponseBodyCameraRole>))]
[Serializable]
public readonly record struct SafetyEventV2MediaResponseBodyCameraRole : IStringEnum
{
    public static readonly SafetyEventV2MediaResponseBodyCameraRole LeftMirrorMount = new(
        Values.LeftMirrorMount
    );

    public static readonly SafetyEventV2MediaResponseBodyCameraRole LeftSide = new(Values.LeftSide);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole RightMirrorMount = new(
        Values.RightMirrorMount
    );

    public static readonly SafetyEventV2MediaResponseBodyCameraRole RightSide = new(
        Values.RightSide
    );

    public static readonly SafetyEventV2MediaResponseBodyCameraRole RearHigh = new(Values.RearHigh);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole RearBumper = new(
        Values.RearBumper
    );

    public static readonly SafetyEventV2MediaResponseBodyCameraRole InCab = new(Values.InCab);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole Front = new(Values.Front);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole Hopper = new(Values.Hopper);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole Other1 = new(Values.Other1);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole Other2 = new(Values.Other2);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole Other3 = new(Values.Other3);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole Other4 = new(Values.Other4);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole LeftBev = new(Values.LeftBev);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole RightBev = new(Values.RightBev);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole RearBev = new(Values.RearBev);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole FrontBev = new(Values.FrontBev);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole OtherBev = new(Values.OtherBev);

    public static readonly SafetyEventV2MediaResponseBodyCameraRole BevNotUsed = new(
        Values.BevNotUsed
    );

    public SafetyEventV2MediaResponseBodyCameraRole(string value)
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
    public static SafetyEventV2MediaResponseBodyCameraRole FromCustom(string value)
    {
        return new SafetyEventV2MediaResponseBodyCameraRole(value);
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
        SafetyEventV2MediaResponseBodyCameraRole value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventV2MediaResponseBodyCameraRole value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventV2MediaResponseBodyCameraRole value) =>
        value.Value;

    public static explicit operator SafetyEventV2MediaResponseBodyCameraRole(string value) =>
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
