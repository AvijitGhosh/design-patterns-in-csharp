using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Implements;
using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryMethodDesignPattern
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
