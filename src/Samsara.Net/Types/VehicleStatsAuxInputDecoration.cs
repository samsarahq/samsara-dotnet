using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsAuxInputDecoration
{
    /// <summary>
    /// The type of &lt;a href="https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs" target="_blank"&gt;auxiliary input&lt;/a&gt; configured for this Vehicle. Once configured, these inputs will generate dynamic, time-series data that will be available to view in the Samsara Dashboard. **By default**: empty. This can be set or updated through the Samsara Dashboard or the API at any time. Inputs 3-13 are only available on gateways with an attached aux expander. The value returned will match what is configured in the dashboard per vehicle.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("value")]
    public required bool Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
