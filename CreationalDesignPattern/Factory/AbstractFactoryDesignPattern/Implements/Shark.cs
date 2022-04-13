using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Implements
{
    public class Shark : IAnimal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }
    }
}
