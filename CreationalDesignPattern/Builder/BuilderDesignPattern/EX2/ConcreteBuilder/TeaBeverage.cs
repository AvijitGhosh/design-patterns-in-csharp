using CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.Builder;

namespace CreationalDesignPattern.Builder.BuilderDesignPattern.EX2.ConcreteBuilder
{
    public class TeaBeverage : BeverageBuilder
    {
        public override void SetBeverageMilk()
        {
            beverageObject.Milk = 10;
        }

        public override void SetBeverageName()
        {
            beverageObject.BeverageName = "Tea";
        }

        public override void SetBeveragePowderQuantity()
        {
            beverageObject.PowderQuantity = 2;
        }

        public override void SetBeverageSugar()
        {
            beverageObject.Sugar = 1;
        }

        public override void SetBeverageWater()
        {
            beverageObject.Water = 15;
        }
    }
}
