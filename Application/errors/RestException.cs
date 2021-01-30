using System;
using System.Net;

public class RestExecption : Exception
{
    public HttpStatusCode Code { get; set; }
    public Object Errors { get; set; }
    public RestExecption(HttpStatusCode code, Object errors)
    {
        this.Errors = errors;
        this.Code = code;

    }
}