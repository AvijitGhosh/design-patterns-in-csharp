namespace CreationalDesignPattern.Factory.FactoryDesignPattern.Interface
{
    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }
}
