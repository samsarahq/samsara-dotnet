using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputValueResponseBody
{
    [JsonPropertyName("machineInput")]
    public AlertObjectMachineInputResponseBody? MachineInput { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
