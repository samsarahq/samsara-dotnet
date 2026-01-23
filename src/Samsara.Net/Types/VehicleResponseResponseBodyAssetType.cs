using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleResponseResponseBodyAssetType>))]
[Serializable]
public readonly record struct VehicleResponseResponseBodyAssetType : IStringEnum
{
    public static readonly VehicleResponseResponseBodyAssetType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly VehicleResponseResponseBodyAssetType Trailer = new(Values.Trailer);

    public static readonly VehicleResponseResponseBodyAssetType Equipment = new(Values.Equipment);

    public static readonly VehicleResponseResponseBodyAssetType Unpowered = new(Values.Unpowered);

    public static readonly VehicleResponseResponseBodyAssetType Vehicle = new(Values.Vehicle);

    public VehicleResponseResponseBodyAssetType(string value)
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
    public static VehicleResponseResponseBodyAssetType FromCustom(string value)
    {
        return new VehicleResponseResponseBodyAssetType(value);
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

    public static bool operator ==(VehicleResponseResponseBodyAssetType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(VehicleResponseResponseBodyAssetType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(VehicleResponseResponseBodyAssetType value) =>
        value.Value;

    public static explicit operator VehicleResponseResponseBodyAssetType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Uncategorized = "uncategorized";

        public const string Trailer = "trailer";

        public const string Equipment = "equipment";

        public const string Unpowered = "unpowered";

        public const string Vehicle = "vehicle";
    }
}
