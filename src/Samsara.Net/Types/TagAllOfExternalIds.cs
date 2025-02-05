using Samsara.Net.Core;

namespace Samsara.Net;

public record TagAllOfExternalIds
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
