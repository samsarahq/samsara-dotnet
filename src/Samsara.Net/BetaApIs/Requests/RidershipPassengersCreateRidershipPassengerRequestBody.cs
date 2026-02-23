using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record RidershipPassengersCreateRidershipPassengerRequestBody
{
    /// <summary>
    /// The Samsara UUID of the ridership account this passenger belongs to.
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    /// <summary>
    /// Classification or grade level of the passenger.  Valid values: `unknown`, `pk1`, `pk2`, `pk3`, `pk4`, `k`, `grade1`, `grade2`, `grade3`, `grade4`, `grade5`, `grade6`, `grade7`, `grade8`, `grade9`, `grade10`, `grade11`, `grade12`
    /// </summary>
    [JsonPropertyName("classification")]
    public RidershipPassengersCreateRidershipPassengerRequestBodyClassification? Classification { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
