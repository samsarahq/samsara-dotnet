using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Sensors;

public record InlineObject5
{
    /// <summary>
    /// List of sensor IDs to query.
    /// </summary>
    [JsonPropertyName("sensors")]
    public IEnumerable<long> Sensors { get; set; } = new List<long>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
