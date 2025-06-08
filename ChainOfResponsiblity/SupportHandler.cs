using System;
namespace ChainOfResponsiblity
{
    public abstract class SupportHandler : ISupportHandler
    {
        private SupportHandler? _next;
        public virtual string Handle(string request)
        {
            return _next?.Handle(request) ?? $"No Handler is currently there to handle {request} this kind of request";
        }

        public SupportHandler SetNext(SupportHandler supportHandler)
        {
            _next = supportHandler;
            return supportHandler;
        }
    }
}

