using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<VehicleWithGatewayTinyResponseResponseBodyAssetType>))]
[Serializable]
public readonly record struct VehicleWithGatewayTinyResponseResponseBodyAssetType : IStringEnum
{
    public static readonly VehicleWithGatewayTinyResponseResponseBodyAssetType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly VehicleWithGatewayTinyResponseResponseBodyAssetType Trailer = new(
        Values.Trailer
    );

    public static readonly VehicleWithGatewayTinyResponseResponseBodyAssetType Equipment = new(
        Values.Equipment
    );

    public static readonly VehicleWithGatewayTinyResponseResponseBodyAssetType Unpowered = new(
        Values.Unpowered
    );

    public static readonly VehicleWithGatewayTinyResponseResponseBodyAssetType Vehicle = new(
        Values.Vehicle
    );

    public VehicleWithGatewayTinyResponseResponseBodyAssetType(string value)
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
    public static VehicleWithGatewayTinyResponseResponseBodyAssetType FromCustom(string value)
    {
        return new VehicleWithGatewayTinyResponseResponseBodyAssetType(value);
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
        VehicleWithGatewayTinyResponseResponseBodyAssetType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        VehicleWithGatewayTinyResponseResponseBodyAssetType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        VehicleWithGatewayTinyResponseResponseBodyAssetType value
    ) => value.Value;

    public static explicit operator VehicleWithGatewayTinyResponseResponseBodyAssetType(
        string value
    ) => new(value);

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
