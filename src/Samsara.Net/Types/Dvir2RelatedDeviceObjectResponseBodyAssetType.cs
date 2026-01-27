using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<Dvir2RelatedDeviceObjectResponseBodyAssetType>))]
[Serializable]
public readonly record struct Dvir2RelatedDeviceObjectResponseBodyAssetType : IStringEnum
{
    public static readonly Dvir2RelatedDeviceObjectResponseBodyAssetType Vehicle = new(
        Values.Vehicle
    );

    public static readonly Dvir2RelatedDeviceObjectResponseBodyAssetType Trailer = new(
        Values.Trailer
    );

    public Dvir2RelatedDeviceObjectResponseBodyAssetType(string value)
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
    public static Dvir2RelatedDeviceObjectResponseBodyAssetType FromCustom(string value)
    {
        return new Dvir2RelatedDeviceObjectResponseBodyAssetType(value);
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
        Dvir2RelatedDeviceObjectResponseBodyAssetType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        Dvir2RelatedDeviceObjectResponseBodyAssetType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(Dvir2RelatedDeviceObjectResponseBodyAssetType value) =>
        value.Value;

    public static explicit operator Dvir2RelatedDeviceObjectResponseBodyAssetType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Vehicle = "Vehicle";

        public const string Trailer = "Trailer";
    }
}
