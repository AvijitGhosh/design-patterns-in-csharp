namespace CreationalDesignPattern.Factory.FactoryMethodDesignPattern.Interface
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
