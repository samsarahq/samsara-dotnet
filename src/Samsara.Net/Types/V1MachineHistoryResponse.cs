using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1MachineHistoryResponse
{
    [JsonPropertyName("machines")]
    public IEnumerable<V1MachineHistoryResponseMachines>? Machines { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
