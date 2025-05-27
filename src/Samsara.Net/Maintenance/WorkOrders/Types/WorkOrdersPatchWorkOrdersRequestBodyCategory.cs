using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance.WorkOrders;

[JsonConverter(typeof(EnumSerializer<WorkOrdersPatchWorkOrdersRequestBodyCategory>))]
public enum WorkOrdersPatchWorkOrdersRequestBodyCategory
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
