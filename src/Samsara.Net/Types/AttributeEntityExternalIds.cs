using Samsara.Net.Core;

namespace Samsara.Net;

public record AttributeEntityExternalIds
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
