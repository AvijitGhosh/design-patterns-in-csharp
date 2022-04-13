using CreationalDesignPattern.FactoryMethodDesignPattern.Implements;
using CreationalDesignPattern.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.FactoryMethodDesignPattern
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
