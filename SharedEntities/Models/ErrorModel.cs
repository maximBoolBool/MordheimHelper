using System.Net;

namespace SharedEntities.Models;

public class ErrorModel
{
    public HttpStatusCode Code;
    
    public string Message;

    public ErrorModel(HttpStatusCode code, string message)
    {
        Code = code;
        Message = message;
    }
    
}