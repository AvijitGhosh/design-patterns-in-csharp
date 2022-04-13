using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Implements
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
