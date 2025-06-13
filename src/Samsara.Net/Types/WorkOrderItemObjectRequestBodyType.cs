using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WorkOrderItemObjectRequestBodyType>))]
public enum WorkOrderItemObjectRequestBodyType
{
    [EnumMember(Value = "DVIR")]
    Dvir,

    [EnumMember(Value = "FAULT")]
    Fault,

    [EnumMember(Value = "FORM")]
    Form,

    [EnumMember(Value = "ISSUE")]
    Issue,

    [EnumMember(Value = "ITEM_TYPE_UNSPECIFIED")]
    ItemTypeUnspecified,

    [EnumMember(Value = "SCHEDULED_MAINTENANCE")]
    ScheduledMaintenance,
}
