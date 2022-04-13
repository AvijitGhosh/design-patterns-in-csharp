using CreationalDesignPattern.FactoryMethodDesignPattern.Implements;
using CreationalDesignPattern.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.FactoryMethodDesignPattern
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
