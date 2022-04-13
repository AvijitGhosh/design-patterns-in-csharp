using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Implements;
using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryMethodDesignPattern
{
    public class TitaniumFactory : CardFactory
    {
        protected override ICreditCard GetCreditCard()
        {
            ICreditCard creditCard = new Titanium();
            return creditCard;
        }
    }
}
