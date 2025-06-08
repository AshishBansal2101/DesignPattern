using System;
namespace ChainOfResponsiblity
{
	public class CustomerSupport : SupportHandler
	{
        public override string Handle(string request)
        {
            if (request.Contains("order") || request.Contains("cancel"))
            {
                return $"SOLVED ::: REACHED :::: TECH ::: Request is passed on to customer dept boiiisss :: request is {request}";
            }

            Console.WriteLine($"Hey Customer dept is unable to process this request {request}:: passing to next designated dept");
            return base.Handle(request);
        }
    }
}

