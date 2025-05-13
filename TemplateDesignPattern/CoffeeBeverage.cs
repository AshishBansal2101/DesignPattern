namespace TemplateDesignPattern
{
    public class CoffeeBeverage : CaffeineBeverage
    {
        protected override void CaffeinePowder()
        {
            Console.WriteLine("Coffee powder added by Cofee beverage -- NESCAFE");
        }

        protected override void Condiment()
        {
            Console.WriteLine("Milk Cream Choco-Powder Added");
        }

        protected override bool AddCondiments()
        {
            return false;
        }
    }
}

