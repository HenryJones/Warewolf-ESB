﻿
namespace Dev2.Runtime.WebServer.Responses
{
    public abstract class ResponseWriter
    {
        public abstract void Write(ICommunicationContext context);

        public abstract void Write(WebServerContext context);
    }
}