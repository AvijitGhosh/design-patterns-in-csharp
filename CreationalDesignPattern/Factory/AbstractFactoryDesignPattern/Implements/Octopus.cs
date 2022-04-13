using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Implements
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
