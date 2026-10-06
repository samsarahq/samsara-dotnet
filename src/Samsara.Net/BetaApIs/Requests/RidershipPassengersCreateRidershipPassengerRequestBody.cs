using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record RidershipPassengersCreateRidershipPassengerRequestBody
{
    /// <summary>
    /// Passenger grade level: `pk1`–`pk4` are pre-kindergarten categories, `k` is kindergarten, and `grade1`–`grade12` are grades 1–12. Use `unknown` when the grade level is not known.  Valid values: `unknown`, `pk1`, `pk2`, `pk3`, `pk4`, `k`, `grade1`, `grade2`, `grade3`, `grade4`, `grade5`, `grade6`, `grade7`, `grade8`, `grade9`, `grade10`, `grade11`, `grade12`
    /// </summary>
    [JsonPropertyName("classification")]
    public RidershipPassengersCreateRidershipPassengerRequestBodyClassification? Classification { get; set; }

    /// <summary>
    /// Customer-defined IDs that link this passenger to another system, such as {"student": "STU-001"}.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Passenger's first name. Maximum 100 characters.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required string FirstName { get; set; }

    /// <summary>
    /// Identifiers used to recognize the passenger, such as RFID card values. Maximum 10.
    /// </summary>
    [JsonPropertyName("identifiers")]
    public IEnumerable<RidershipPassengerIdentifierInputRequestBody>? Identifiers { get; set; }

    /// <summary>
    /// Passenger's last name. Maximum 100 characters.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("specialInstructions")]
    public RidershipPassengerSpecialInstructionsInputRequestBody? SpecialInstructions { get; set; }

    /// <summary>
    /// Up to 10 Samsara tag IDs to assign to the passenger; external IDs are not supported here. Omit or send `[]` to create a passenger without tags.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
