using CreationalDesignPattern.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.FactoryMethodDesignPattern.Implements
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 50;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 70000;
        }
    }
}
