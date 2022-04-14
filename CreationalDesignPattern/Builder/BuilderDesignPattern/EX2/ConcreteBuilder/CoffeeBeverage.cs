using CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.Builder;

namespace CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.ConcreteBuilder
{
    public class CoffeeBeverage : BeverageBuilder
    {
        public override void SetBeverageMilk()
        {
            beverageObject.Milk = 7;
        }

        public override void SetBeverageName()
        {
            beverageObject.BeverageName = "Coffee";
        }

        public override void SetBeveragePowderQuantity()
        {
            beverageObject.PowderQuantity = 1;
        }

        public override void SetBeverageSugar()
        {
            beverageObject.Sugar = 2;
        }

        public override void SetBeverageWater()
        {
            beverageObject.Water = 14;
        }
    }
}
