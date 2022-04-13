using CreationalDesignPattern.Factory.FactoryDesignPattern.Implements;
using CreationalDesignPattern.Factory.FactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.FactoryDesignPattern
{
    public static class CardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard card = null;
            if (cardType== "Platinum")
            {
                card = new Platinum();
            }
            else if (cardType == "Titanium")
            {
                card = new Titanium();
            }
            else if (cardType == "MoneyBack")
            {
                card = new MoneyBack();
            }
            return card;

        }
    }
}
