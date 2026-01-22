using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

[JsonConverter(typeof(StringEnumSerializer<GetDriverVehicleAssignmentsRequestAssignmentType>))]
[Serializable]
public readonly record struct GetDriverVehicleAssignmentsRequestAssignmentType : IStringEnum
{
    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType Hos = new(Values.Hos);

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType IdCard = new(
        Values.IdCard
    );

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType Static = new(
        Values.Static
    );

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType FaceId = new(
        Values.FaceId
    );

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType Tachograph = new(
        Values.Tachograph
    );

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType SafetyManual = new(
        Values.SafetyManual
    );

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType Rfid = new(Values.Rfid);

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType Trailer = new(
        Values.Trailer
    );

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType External = new(
        Values.External
    );

    public static readonly GetDriverVehicleAssignmentsRequestAssignmentType QrCode = new(
        Values.QrCode
    );

    public GetDriverVehicleAssignmentsRequestAssignmentType(string value)
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
    public static GetDriverVehicleAssignmentsRequestAssignmentType FromCustom(string value)
    {
        return new GetDriverVehicleAssignmentsRequestAssignmentType(value);
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
        GetDriverVehicleAssignmentsRequestAssignmentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetDriverVehicleAssignmentsRequestAssignmentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GetDriverVehicleAssignmentsRequestAssignmentType value
    ) => value.Value;

    public static explicit operator GetDriverVehicleAssignmentsRequestAssignmentType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
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
