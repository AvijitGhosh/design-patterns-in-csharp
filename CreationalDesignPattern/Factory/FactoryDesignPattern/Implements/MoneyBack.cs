using CreationalDesignPattern.Factory.FactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryDesignPattern.Implements
{
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 100;
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
    }
}
