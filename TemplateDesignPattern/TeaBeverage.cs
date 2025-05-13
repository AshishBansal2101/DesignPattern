namespace TemplateDesignPattern
{
	public class TeaBeverage : CaffeineBeverage
	{
		public TeaBeverage()
		{
		}

        protected override void CaffeinePowder()
        {
            Console.WriteLine("Tea powder added by tea beverage -- WAAH TAJ");
        }

        protected override void Condiment()
        {
            Console.WriteLine("Adrak tulsi Milk Elaichi Added");

        }
    }
}

