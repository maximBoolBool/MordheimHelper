using System.Net;

namespace SharedEntities.Models;

/// <summary>
///     Предусмотренные ошибки
/// </summary>
public class ErrorException : Exception
{
    public ErrorModel error { get; set; }
    
    /// <summary>
    ///     .ctor
    /// </summary>
    /// <param name="error"></param>
    public ErrorException(ErrorModel error)
    {
        error = error;
    }

    /// <summary>
    ///     .ctor
    /// </summary>
    /// <param name="error"></param>
    public ErrorException(HttpStatusCode code, string message)
    {
        error = new ErrorModel(code, message);
    }
}