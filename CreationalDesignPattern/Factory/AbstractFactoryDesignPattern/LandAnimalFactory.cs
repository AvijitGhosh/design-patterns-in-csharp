using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Implements;
using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.AbstractFactoryDesignPattern
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (AnimalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (AnimalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }
}
