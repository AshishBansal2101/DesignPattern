using System;
namespace ChainOfResponsiblity
{
	public interface ISupportHandler
	{
		SupportHandler SetNext(SupportHandler supportHandler);
		string Handle(string request);
	}
}

