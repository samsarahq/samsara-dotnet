namespace Samsara.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class UnauthorizedError(object body) : SamsaraApiException("UnauthorizedError", 401, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new object Body => body;
}
