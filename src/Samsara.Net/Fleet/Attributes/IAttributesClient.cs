using Samsara.Net;

namespace Samsara.Net.Fleet.Attributes;

public partial interface IAttributesClient
{
    Task UpdateAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
