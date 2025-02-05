using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionsGetFormSubmissionsResponseBody
{
    /// <summary>
    /// List of form submissions.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<FormSubmissionResponseObjectResponseBody> Data { get; set; } =
        new List<FormSubmissionResponseObjectResponseBody>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
