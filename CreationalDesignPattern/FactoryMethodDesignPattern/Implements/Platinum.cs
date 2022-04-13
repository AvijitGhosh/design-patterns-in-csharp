using CreationalDesignPattern.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.FactoryMethodDesignPattern.Implements
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 150;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 65000;
        }
    }
}
