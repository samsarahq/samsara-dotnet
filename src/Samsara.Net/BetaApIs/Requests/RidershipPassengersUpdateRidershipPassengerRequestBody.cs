using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record RidershipPassengersUpdateRidershipPassengerRequestBody
{
    /// <summary>
    /// ID of the ridership passenger. This can either be the Samsara-specified UUID, or an external ID. External IDs are customer-specified key-value pairs. To specify an external ID, use the following format: `key:value`. For example, `student:STU-001`.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <summary>
    /// Classification or grade level of the passenger.  Valid values: `unknown`, `pk1`, `pk2`, `pk3`, `pk4`, `k`, `grade1`, `grade2`, `grade3`, `grade4`, `grade5`, `grade6`, `grade7`, `grade8`, `grade9`, `grade10`, `grade11`, `grade12`
    /// </summary>
    [JsonPropertyName("classification")]
    public RidershipPassengersUpdateRidershipPassengerRequestBodyClassification? Classification { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// First name of the passenger.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    /// <summary>
    /// List of identifiers associated with the passenger.
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IEnumerable<RidershipPassengerIdentifierInputRequestBody>? Identifiers { get; set; }

    /// <summary>
    /// Last name of the passenger.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("specialInstructions")]
    public RidershipPassengerSpecialInstructionsInputRequestBody? SpecialInstructions { get; set; }

    /// <summary>
    /// IDs of tags to associate with the passenger.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
