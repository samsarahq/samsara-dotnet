using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UsDriverRulesetOverrideCycle>))]
public enum UsDriverRulesetOverrideCycle
{
    [EnumMember(Value = "USA Property (8/70)")]
    UsaProperty870,

    [EnumMember(Value = "USA Property (7/60)")]
    UsaProperty760,

    [EnumMember(Value = "USA Passenger (8/70)")]
    UsaPassenger870,

    [EnumMember(Value = "USA Passenger (7/60)")]
    UsaPassenger760,

    [EnumMember(Value = "Alaska Property (8/80)")]
    AlaskaProperty880,

    [EnumMember(Value = "Alaska Property (7/70)")]
    AlaskaProperty770,

    [EnumMember(Value = "Alaska Passenger (8/80)")]
    AlaskaPassenger880,

    [EnumMember(Value = "Alaska Passenger (7/70)")]
    AlaskaPassenger770,

    [EnumMember(Value = "California School/FLV (8/80)")]
    CaliforniaSchoolFlv880,

    [EnumMember(Value = "California Farm (8/112)")]
    CaliforniaFarm8112,

    [EnumMember(Value = "California Property (8/80)")]
    CaliforniaProperty880,

    [EnumMember(Value = "California Flammable Liquid (8/80)")]
    CaliforniaFlammableLiquid880,

    [EnumMember(Value = "California Passenger (8/80)")]
    CaliforniaPassenger880,

    [EnumMember(Value = "California Motion Picture (8/80)")]
    CaliforniaMotionPicture880,

    [EnumMember(Value = "Florida (8/80)")]
    Florida880,

    [EnumMember(Value = "Florida (7/70)")]
    Florida770,

    [EnumMember(Value = "Nebraska (8/80)")]
    Nebraska880,

    [EnumMember(Value = "Nebraska (7/70)")]
    Nebraska770,

    [EnumMember(Value = "North Carolina (8/80)")]
    NorthCarolina880,

    [EnumMember(Value = "North Carolina (7/70)")]
    NorthCarolina770,

    [EnumMember(Value = "Oklahoma (8/70)")]
    Oklahoma870,

    [EnumMember(Value = "Oklahoma (7/60)")]
    Oklahoma760,

    [EnumMember(Value = "Oregon (8/80)")]
    Oregon880,

    [EnumMember(Value = "Oregon (7/70)")]
    Oregon770,

    [EnumMember(Value = "South Carolina (8/80)")]
    SouthCarolina880,

    [EnumMember(Value = "South Carolina (7/70)")]
    SouthCarolina770,

    [EnumMember(Value = "Texas (7/70)")]
    Texas770,

    [EnumMember(Value = "Wisconsin (8/80)")]
    Wisconsin880,

    [EnumMember(Value = "Wisconsin (7/70)")]
    Wisconsin770,
}
