using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ReportsCreateReportRunRequestBody
{
    [JsonPropertyName("reportConfig")]
    public required CreateReportConfigObjectRequestBody ReportConfig { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
