namespace Samsara.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class TooManyRequestsError(object body)
    : SamsaraClientApiException("TooManyRequestsError", 429, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new object Body => body;
}
