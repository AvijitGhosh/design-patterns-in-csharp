using CreationalDesignPattern.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.AbstractFactoryDesignPattern.Implements
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
