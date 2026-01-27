using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType>)
)]
[Serializable]
public readonly record struct DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType
    : IStringEnum
{
    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType Invalid = new(
        Values.Invalid
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType Unknown = new(
        Values.Unknown
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType Hos = new(
        Values.Hos
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType IdCard = new(
        Values.IdCard
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType Static = new(
        Values.Static
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType FaceId = new(
        Values.FaceId
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType Tachograph =
        new(Values.Tachograph);

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType SafetyManual =
        new(Values.SafetyManual);

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType Rfid = new(
        Values.Rfid
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType Trailer = new(
        Values.Trailer
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType External = new(
        Values.External
    );

    public static readonly DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType QrCode = new(
        Values.QrCode
    );

    public DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType(string value)
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
    public static DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType FromCustom(string value)
    {
        return new DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType(value);
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
        DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType value
    ) => value.Value;

    public static explicit operator DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Invalid = "invalid";

        public const string Unknown = "unknown";

        public const string Hos = "HOS";

        public const string IdCard = "idCard";

        public const string Static = "static";

        public const string FaceId = "faceId";

        public const string Tachograph = "tachograph";

        public const string SafetyManual = "safetyManual";

        public const string Rfid = "RFID";

        public const string Trailer = "trailer";

        public const string External = "external";

        public const string QrCode = "qrCode";
    }
}
