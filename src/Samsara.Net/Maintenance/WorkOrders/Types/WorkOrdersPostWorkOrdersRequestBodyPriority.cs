using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance.WorkOrders;

[JsonConverter(typeof(EnumSerializer<WorkOrdersPostWorkOrdersRequestBodyPriority>))]
public enum WorkOrdersPostWorkOrdersRequestBodyPriority
{
    [EnumMember(Value = "High")]
    High,

    [EnumMember(Value = "Low")]
    Low,

    [EnumMember(Value = "Medium")]
    Medium,

    [EnumMember(Value = "Urgent")]
    Urgent,
}
