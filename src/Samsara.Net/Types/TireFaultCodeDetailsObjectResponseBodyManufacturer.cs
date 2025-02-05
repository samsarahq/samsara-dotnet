using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TireFaultCodeDetailsObjectResponseBodyManufacturer>))]
public enum TireFaultCodeDetailsObjectResponseBodyManufacturer
{
    [EnumMember(Value = "MANUFACTURER_BENDIX")]
    ManufacturerBendix,

    [EnumMember(Value = "MANUFACTURER_CONTINENTAL")]
    ManufacturerContinental,

    [EnumMember(Value = "MANUFACTURER_DORAN")]
    ManufacturerDoran,

    [EnumMember(Value = "MANUFACTURER_HENDRICKSON")]
    ManufacturerHendrickson,

    [EnumMember(Value = "MANUFACTURER_INVALID")]
    ManufacturerInvalid,

    [EnumMember(Value = "MANUFACTURER_PRESSURE_PRO")]
    ManufacturerPressurePro,

    [EnumMember(Value = "MANUFACTURER_UNIVERSAL_J1939")]
    ManufacturerUniversalJ1939,

    [EnumMember(Value = "MANUFACTURER_UNIVERSAL_R141")]
    ManufacturerUniversalR141,
}
