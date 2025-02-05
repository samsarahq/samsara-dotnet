using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DefectTypesResponseDataResponseBodySectionType>))]
public enum DefectTypesResponseDataResponseBodySectionType
{
    [EnumMember(Value = "exteriorFront")]
    ExteriorFront,

    [EnumMember(Value = "exteriorRear")]
    ExteriorRear,

    [EnumMember(Value = "exteriorSideUnderneath")]
    ExteriorSideUnderneath,

    [EnumMember(Value = "interiorDriverCab")]
    InteriorDriverCab,

    [EnumMember(Value = "interiorPassengerArea")]
    InteriorPassengerArea,

    [EnumMember(Value = "other")]
    Other,

    [EnumMember(Value = "unknown")]
    Unknown,
}
