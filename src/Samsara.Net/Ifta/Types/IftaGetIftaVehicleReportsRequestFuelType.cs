using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Ifta;

[JsonConverter(typeof(EnumSerializer<IftaGetIftaVehicleReportsRequestFuelType>))]
public enum IftaGetIftaVehicleReportsRequestFuelType
{
    [EnumMember(Value = "Unspecified")]
    Unspecified,

    [EnumMember(Value = "A55")]
    A55,

    [EnumMember(Value = "Biodiesel")]
    Biodiesel,

    [EnumMember(Value = "CompressedNaturalGas")]
    CompressedNaturalGas,

    [EnumMember(Value = "Diesel")]
    Diesel,

    [EnumMember(Value = "E85")]
    E85,

    [EnumMember(Value = "Electricity")]
    Electricity,

    [EnumMember(Value = "Ethanol")]
    Ethanol,

    [EnumMember(Value = "Gasohol")]
    Gasohol,

    [EnumMember(Value = "Gasoline")]
    Gasoline,

    [EnumMember(Value = "Hydrogen")]
    Hydrogen,

    [EnumMember(Value = "LiquifiedNaturalGas")]
    LiquifiedNaturalGas,

    [EnumMember(Value = "M85")]
    M85,

    [EnumMember(Value = "Methanol")]
    Methanol,

    [EnumMember(Value = "Propane")]
    Propane,

    [EnumMember(Value = "Other")]
    Other,
}
