using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PairResultDeviceObjectResponseBodyType>))]
[Serializable]
public readonly record struct PairResultDeviceObjectResponseBodyType : IStringEnum
{
    public static readonly PairResultDeviceObjectResponseBodyType Vehicle = new(Values.Vehicle);

    public static readonly PairResultDeviceObjectResponseBodyType Asset = new(Values.Asset);

    public static readonly PairResultDeviceObjectResponseBodyType Equipment = new(Values.Equipment);

    public static readonly PairResultDeviceObjectResponseBodyType Trailer = new(Values.Trailer);

    public static readonly PairResultDeviceObjectResponseBodyType Industrial = new(
        Values.Industrial
    );

    public static readonly PairResultDeviceObjectResponseBodyType AssetTag = new(Values.AssetTag);

    public PairResultDeviceObjectResponseBodyType(string value)
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
    public static PairResultDeviceObjectResponseBodyType FromCustom(string value)
    {
        return new PairResultDeviceObjectResponseBodyType(value);
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

    public static bool operator ==(PairResultDeviceObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PairResultDeviceObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PairResultDeviceObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator PairResultDeviceObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Vehicle = "vehicle";

        public const string Asset = "asset";

        public const string Equipment = "equipment";

        public const string Trailer = "trailer";

        public const string Industrial = "industrial";

        public const string AssetTag = "assetTag";
    }
}
