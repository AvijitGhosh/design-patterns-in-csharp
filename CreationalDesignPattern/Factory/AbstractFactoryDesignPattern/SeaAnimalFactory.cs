using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Implements;
using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.AbstractFactoryDesignPattern
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (AnimalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null;
        }
    }
}
