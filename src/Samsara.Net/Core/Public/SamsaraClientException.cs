namespace Samsara.Net;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class SamsaraClientException(string message, Exception? innerException = null)
    : Exception(message, innerException);
