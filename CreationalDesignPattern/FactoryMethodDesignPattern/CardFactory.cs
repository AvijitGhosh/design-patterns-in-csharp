using CreationalDesignPattern.FactoryMethodDesignPattern.Interface;

namespace CreationalDesignPattern.FactoryMethodDesignPattern
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
