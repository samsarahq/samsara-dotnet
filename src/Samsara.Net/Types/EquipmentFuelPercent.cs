using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record EquipmentFuelPercent
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The percent of fuel in the unit of equipment.
    /// </summary>
    [JsonPropertyName("value")]
    public required int Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
