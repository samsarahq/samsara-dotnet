using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.DriverVehicleAssignments;

[JsonConverter(typeof(EnumSerializer<DriverVehicleAssignmentsGetRequestAssignmentType>))]
public enum DriverVehicleAssignmentsGetRequestAssignmentType
{
    [EnumMember(Value = "HOS")]
    Hos,

    [EnumMember(Value = "idCard")]
    IdCard,

    [EnumMember(Value = "static")]
    Static,

    [EnumMember(Value = "faceId")]
    FaceId,

    [EnumMember(Value = "tachograph")]
    Tachograph,

    [EnumMember(Value = "safetyManual")]
    SafetyManual,

    [EnumMember(Value = "RFID")]
    Rfid,

    [EnumMember(Value = "trailer")]
    Trailer,

    [EnumMember(Value = "external")]
    External,

    [EnumMember(Value = "qrCode")]
    QrCode,
}
