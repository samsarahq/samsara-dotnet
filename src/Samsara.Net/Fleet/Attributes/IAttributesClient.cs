using Samsara.Net;

namespace Samsara.Net.Fleet.Attributes;

public partial interface IAttributesClient
{
    Task UpdateAsync(
        UpdateAttributesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
