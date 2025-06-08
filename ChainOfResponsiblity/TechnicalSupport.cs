namespace ChainOfResponsiblity
{
	public class TechnicalSupport : SupportHandler
	{
        public override string Handle(string request)
        {
            if (request.Contains("tech") || request.Contains("crash"))
            {
                return $"SOLVED ::: REACHED :::: TECH ::: Request is passed on to tech guysss :: request is {request}";
            }

            Console.WriteLine($"Hey tech dept is unable to process this request {request}:: passing to next designated dept");
            return base.Handle(request);
        }
    }
}

