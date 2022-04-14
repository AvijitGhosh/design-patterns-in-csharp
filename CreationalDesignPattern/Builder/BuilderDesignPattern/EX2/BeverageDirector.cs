using CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.Builder;

namespace CreationalDesignPattern.Builder.BuilderDesignPattern.EX2
{
    public class BeverageDirector 
    {
        public Beverage MakeBeverage(BeverageBuilder beverageBuilder)
        {
            beverageBuilder.CreateNewBeverage();
            beverageBuilder.SetBeverageName();
            beverageBuilder.SetBeverageWater();
            beverageBuilder.SetBeverageSugar();
            beverageBuilder.SetBeveragePowderQuantity();
            beverageBuilder.SetBeverageMilk();
            return beverageBuilder.GetBeverage();
        }
    }
}
