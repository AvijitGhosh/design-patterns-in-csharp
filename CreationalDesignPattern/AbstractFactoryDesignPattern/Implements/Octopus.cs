using CreationalDesignPattern.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.AbstractFactoryDesignPattern.Implements
{
    public class Octopus : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
