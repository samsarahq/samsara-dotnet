using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record QualificationsPostQualificationRecordRequestBody
{
    /// <summary>
    /// Expiration date. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Other custom fields in a qualification record.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<QualificationRecordRequestFieldInputObjectRequestBody>? Fields { get; set; }

    /// <summary>
    /// Issue/effective date. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("issueDate")]
    public required DateTime IssueDate { get; set; }

    [JsonPropertyName("owner")]
    public required QualificationOwnerRequestObjectRequestBody Owner { get; set; }

    [JsonPropertyName("qualificationType")]
    public required QualificationTypeRequestObjectRequestBody QualificationType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
