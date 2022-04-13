using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Implements
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }
}
