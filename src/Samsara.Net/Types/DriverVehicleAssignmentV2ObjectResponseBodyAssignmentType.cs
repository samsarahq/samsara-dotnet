using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType>))]
public enum DriverVehicleAssignmentV2ObjectResponseBodyAssignmentType
{
    [EnumMember(Value = "invalid")]
    Invalid,

    [EnumMember(Value = "unknown")]
    Unknown,

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
