using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance.WorkOrders;

[JsonConverter(typeof(EnumSerializer<WorkOrdersPatchWorkOrdersRequestBodyStatus>))]
public enum WorkOrdersPatchWorkOrdersRequestBodyStatus
{
    [EnumMember(Value = "Assigned")]
    Assigned,

    [EnumMember(Value = "Cancelled")]
    Cancelled,

    [EnumMember(Value = "Closed")]
    Closed,

    [EnumMember(Value = "Completed")]
    Completed,

    [EnumMember(Value = "In Progress")]
    InProgress,

    [EnumMember(Value = "On Hold")]
    OnHold,

    [EnumMember(Value = "Open")]
    Open,

    [EnumMember(Value = "Pending Approval")]
    PendingApproval,

    [EnumMember(Value = "Pending Parts")]
    PendingParts,
}
