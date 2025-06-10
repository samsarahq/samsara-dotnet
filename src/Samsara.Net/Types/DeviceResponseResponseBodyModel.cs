using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DeviceResponseResponseBodyModel>))]
public enum DeviceResponseResponseBodyModel
{
    [EnumMember(Value = "AG24")]
    Ag24,

    [EnumMember(Value = "AG24EU")]
    Ag24Eu,

    [EnumMember(Value = "AG26")]
    Ag26,

    [EnumMember(Value = "AG26EU")]
    Ag26Eu,

    [EnumMember(Value = "AG45")]
    Ag45,

    [EnumMember(Value = "AG45EU")]
    Ag45Eu,

    [EnumMember(Value = "AG46")]
    Ag46,

    [EnumMember(Value = "AG46EU")]
    Ag46Eu,

    [EnumMember(Value = "AG46P")]
    Ag46P,

    [EnumMember(Value = "AG46PEU")]
    Ag46Peu,

    [EnumMember(Value = "AG51")]
    Ag51,

    [EnumMember(Value = "AG51EU")]
    Ag51Eu,

    [EnumMember(Value = "AG52")]
    Ag52,

    [EnumMember(Value = "AG52EU")]
    Ag52Eu,

    [EnumMember(Value = "AG53")]
    Ag53,

    [EnumMember(Value = "AG53EU")]
    Ag53Eu,

    [EnumMember(Value = "AT11")]
    At11,

    [EnumMember(Value = "CM31")]
    Cm31,

    [EnumMember(Value = "CM32")]
    Cm32,

    [EnumMember(Value = "CM33")]
    Cm33,

    [EnumMember(Value = "CM34")]
    Cm34,

    [EnumMember(Value = "VG34")]
    Vg34,

    [EnumMember(Value = "VG34EU")]
    Vg34Eu,

    [EnumMember(Value = "VG34FN")]
    Vg34Fn,

    [EnumMember(Value = "VG34M")]
    Vg34M,

    [EnumMember(Value = "VG54EU")]
    Vg54Eu,

    [EnumMember(Value = "VG54NA")]
    Vg54Na,

    [EnumMember(Value = "VG55EU")]
    Vg55Eu,

    [EnumMember(Value = "VG55NA")]
    Vg55Na,
}
