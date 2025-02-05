using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionsGetFormSubmissionsPdfExportsResponseBody
{
    [JsonPropertyName("data")]
    public required FormSubmissionPdfExportResponseObjectResponseBody Data { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
