
namespace CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.Builder
{
    public abstract class BeverageBuilder
    {
        protected Beverage beverageObject;
        public abstract void SetBeverageWater();
        public abstract void SetBeverageMilk();

        public abstract void SetBeverageSugar();
        public abstract void SetBeveragePowderQuantity();
        public abstract void SetBeverageName();

        public void CreateNewBeverage()
        {
            beverageObject = new Beverage();
        }

        public Beverage GetBeverage()
        {
            return beverageObject;
        }
    }
}
