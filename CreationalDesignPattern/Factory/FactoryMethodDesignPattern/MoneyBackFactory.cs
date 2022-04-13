using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Implements;
using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryMethodDesignPattern
{
    public class MoneyBackFactory : CardFactory
    {
        protected override ICreditCard GetCreditCard()
        {
            ICreditCard creditCard = new MoneyBack();
            return creditCard;
        }
    }
}
