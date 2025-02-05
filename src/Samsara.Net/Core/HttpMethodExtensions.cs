using System.Net.Http;

namespace Samsara.Net.Core;

internal static class HttpMethodExtensions
{
    public static readonly HttpMethod Patch = new("PATCH");
}
