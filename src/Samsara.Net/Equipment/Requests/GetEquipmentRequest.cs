using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Equipment;

[Serializable]
public record GetEquipmentRequest
{
    /// <summary>
    /// Samsara ID of the Equipment.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
