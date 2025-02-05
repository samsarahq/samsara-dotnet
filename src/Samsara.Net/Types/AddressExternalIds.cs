using Samsara.Net.Core;

namespace Samsara.Net;

public record AddressExternalIds
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
