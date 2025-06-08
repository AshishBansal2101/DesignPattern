using System;
namespace ChainOfResponsiblity
{
	public class SalesSupport : SupportHandler
	{
        public override string Handle(string request)
        {
            if (request.Contains("price") || request.Contains("discount"))
            {
                return $"SOLVED ::: REACHED :::: SALES :::: Request is passed on to salesss Mennnn :: request is {request}";
            }

            Console.WriteLine($"Hey sales dept is unable to process this request {request}:: passing to next designated dept");
            return base.Handle(request);
        }
    }
}

