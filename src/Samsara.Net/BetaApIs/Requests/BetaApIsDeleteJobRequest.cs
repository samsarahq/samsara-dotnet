using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

public record BetaApIsDeleteJobRequest
{
    /// <summary>
    /// A jobId or uuid in STRING format. JobId must be prefixed with `jobId:`(Examples: `"8d218e6c-7a16-4f9f-90f7-cc1d93b9e596"`, `"jobId:98765"`).
    /// </summary>
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
