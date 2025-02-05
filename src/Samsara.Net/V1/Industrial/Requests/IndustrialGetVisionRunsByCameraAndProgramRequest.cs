using Samsara.Net.Core;

namespace Samsara.Net.V1.Industrial;

public record IndustrialGetVisionRunsByCameraAndProgramRequest
{
    /// <summary>
    /// Include is a filter parameter. Accepts 'pass', 'reject' or 'no_read'.
    /// </summary>
    public string? Include { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
