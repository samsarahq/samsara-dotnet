using System;

namespace Samsara.Net;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class SamsaraException(string message, Exception? innerException = null)
    : Exception(message, innerException);
