using CreationalDesignPattern.FactoryMethodDesignPattern.Implements;
using CreationalDesignPattern.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.FactoryMethodDesignPattern
{
    public class PlatinumFactory : CardFactory
    {
        protected override ICreditCard GetCreditCard()
        {
            ICreditCard creditCard = new Platinum();
            return creditCard;
        }
    }
}
