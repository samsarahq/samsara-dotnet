using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentInstalledGateway
{
    /// <summary>
    /// The model of the installed Samsara gateway.
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// The serial of the installed Samsara gateway.
    /// </summary>
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
