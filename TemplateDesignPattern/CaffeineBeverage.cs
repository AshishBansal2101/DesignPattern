namespace TemplateDesignPattern
{
    public abstract class CaffeineBeverage
	{
		public void Template()
		{
			BoilWater();
			CaffeinePowder();
			if (AddCondiments())
			{
				Condiment();
			}
			PourInGlass();
		}

		private void BoilWater()
		{
			Console.WriteLine("Boiling Water");
		}

		private void PourInGlass()
		{
			Console.WriteLine("Pouring in glass..\nEnjoy....\n\n");
		}

		protected virtual bool AddCondiments()//hook
		{
			return true;
		}

		protected abstract void CaffeinePowder();

		protected abstract void Condiment();
	}
		
}

