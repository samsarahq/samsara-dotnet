namespace Samsara.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
public class NotImplementedError(object body)
    : SamsaraApiException("NotImplementedError", 501, body)
{
    /// <summary>
    /// The body of the response that triggered the exception.
    /// </summary>
    public new object Body => body;
}
