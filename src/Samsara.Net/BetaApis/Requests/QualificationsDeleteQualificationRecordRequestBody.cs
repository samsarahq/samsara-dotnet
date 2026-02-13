using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[Serializable]
public record QualificationsDeleteQualificationRecordRequestBody
{
    /// <summary>
    /// ID of the qualification record to delete.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
