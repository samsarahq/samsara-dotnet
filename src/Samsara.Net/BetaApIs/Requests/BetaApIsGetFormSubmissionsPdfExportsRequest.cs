using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsGetFormSubmissionsPdfExportsRequest
{
    /// <summary>
    /// ID of the form submission PDF export.
    /// </summary>
    public required string PdfId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
