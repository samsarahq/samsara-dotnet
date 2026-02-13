using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record EquipmentPatchEquipmentRequestBody
{
    /// <summary>
    /// List of attributes associated with the entity
    /// </summary>
    [JsonPropertyName("attributes")]
    public IEnumerable<GoaAttributeTiny>? Attributes { get; set; }

    /// <summary>
    /// When you provide a manual engine hours override, Samsara will begin updating a equipment's engine hours used since this override was set.
    /// </summary>
    [JsonPropertyName("engineHours")]
    public long? EngineHours { get; set; }

    /// <summary>
    /// The serial number of the equipment.
    /// </summary>
    [JsonPropertyName("equipmentSerialNumber")]
    public string? EquipmentSerialNumber { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// The human-readable name of the Equipment. This is set by a fleet administrator and will appear in both Samsara’s cloud dashboard as well as the Samsara Driver mobile app. By default, this name is the serial number of the Samsara Asset Gateway. It can be set or updated through the Samsara Dashboard or through the API at any time.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// These are generic notes about the Equipment. Empty by default. Can be set or updated through the Samsara Dashboard or the API at any time.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// When you provide a manual odometer override, Samsara will begin updating a equipment's odometer using GPS distance traveled since this override was set.
    /// </summary>
    [JsonPropertyName("odometerMeters")]
    public long? OdometerMeters { get; set; }

    /// <summary>
    /// An array of IDs of tags to associate with this equipment. If your access to the API is scoped by one or more tags, this field is required to pass in.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
