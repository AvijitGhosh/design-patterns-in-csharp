using CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryMethodDesignPattern
{
    public abstract class CardFactory
    {
        protected abstract ICreditCard GetCreditCard();

        public ICreditCard SetCreditCard()
        {
            return this.GetCreditCard();
        }
    }
}
