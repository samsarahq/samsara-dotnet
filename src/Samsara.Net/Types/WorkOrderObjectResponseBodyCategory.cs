using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WorkOrderObjectResponseBodyCategory>))]
public enum WorkOrderObjectResponseBodyCategory
{
    [EnumMember(Value = "Annual")]
    Annual,

    [EnumMember(Value = "Corrective")]
    Corrective,

    [EnumMember(Value = "Damage Repair")]
    DamageRepair,

    [EnumMember(Value = "Preventive")]
    Preventive,

    [EnumMember(Value = "Recall")]
    Recall,

    [EnumMember(Value = "Unspecified")]
    Unspecified,
}
