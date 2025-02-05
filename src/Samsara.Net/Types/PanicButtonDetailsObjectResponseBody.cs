using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PanicButtonDetailsObjectResponseBody
{
    /// <summary>
    /// If true, only receive alerts when the panic button is pressed, otherwise receive alerts when the panic button is pressed or looses connection.
    /// </summary>
    [JsonPropertyName("isFilteringOutPowerLoss")]
    public required bool IsFilteringOutPowerLoss { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
