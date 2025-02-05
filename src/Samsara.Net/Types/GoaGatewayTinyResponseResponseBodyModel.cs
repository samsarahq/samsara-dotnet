using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<GoaGatewayTinyResponseResponseBodyModel>))]
public enum GoaGatewayTinyResponseResponseBodyModel
{
    [EnumMember(Value = "AG15")]
    Ag15,

    [EnumMember(Value = "AG24")]
    Ag24,

    [EnumMember(Value = "AG24EU")]
    Ag24Eu,

    [EnumMember(Value = "AG26")]
    Ag26,

    [EnumMember(Value = "AG26EU")]
    Ag26Eu,

    [EnumMember(Value = "AG41")]
    Ag41,

    [EnumMember(Value = "AG41EU")]
    Ag41Eu,

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

    [EnumMember(Value = "IG15")]
    Ig15,

    [EnumMember(Value = "IG21")]
    Ig21,

    [EnumMember(Value = "IG41")]
    Ig41,

    [EnumMember(Value = "IG61")]
    Ig61,

    [EnumMember(Value = "SG1")]
    Sg1,

    [EnumMember(Value = "SG1B")]
    Sg1B,

    [EnumMember(Value = "SG1G")]
    Sg1G,

    [EnumMember(Value = "SG1G32")]
    Sg1G32,

    [EnumMember(Value = "SG1x")]
    Sg1X,

    [EnumMember(Value = "VG32")]
    Vg32,

    [EnumMember(Value = "VG33")]
    Vg33,

    [EnumMember(Value = "VG34")]
    Vg34,

    [EnumMember(Value = "VG34EU")]
    Vg34Eu,

    [EnumMember(Value = "VG34FN")]
    Vg34Fn,

    [EnumMember(Value = "VG34M")]
    Vg34M,

    [EnumMember(Value = "VG54ATT")]
    Vg54Att,

    [EnumMember(Value = "VG54EU")]
    Vg54Eu,

    [EnumMember(Value = "VG54FN")]
    Vg54Fn,

    [EnumMember(Value = "VG54NA")]
    Vg54Na,

    [EnumMember(Value = "VG54NAE")]
    Vg54Nae,

    [EnumMember(Value = "VG54NAH")]
    Vg54Nah,

    [EnumMember(Value = "VG55EU")]
    Vg55Eu,

    [EnumMember(Value = "VG55FN")]
    Vg55Fn,

    [EnumMember(Value = "VG55NA")]
    Vg55Na,
}
