using Samsara.Net.Core;

namespace Samsara.Net;

public record ExtendedDriverTinyResponseExternalIds
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
