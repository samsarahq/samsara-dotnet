using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record QualificationsPatchQualificationRecordRequestBody
{
    /// <summary>
    /// Expiration date. UTC timestamp in RFC 3339 format. Set to '1970-01-01T00:00:00Z' to clear existing expiration date.
    /// </summary>
    [JsonPropertyName("expirationDate")]
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// A map of external ids
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    /// <summary>
    /// Other custom fields in a qualification record. Only set fields that needs to be updated.
    /// </summary>
    [JsonPropertyName("fields")]
    public IEnumerable<QualificationRecordRequestFieldInputObjectRequestBody>? Fields { get; set; }

    /// <summary>
    /// ID of the qualification record to update.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Issue/effective date. UTC timestamp in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("issueDate")]
    public DateTime? IssueDate { get; set; }

    [JsonPropertyName("owner")]
    public QualificationOwnerRequestObjectRequestBody? Owner { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
