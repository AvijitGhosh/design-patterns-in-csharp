using CreationalDesignPattern.Factory.FactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryDesignPattern.Implements
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
