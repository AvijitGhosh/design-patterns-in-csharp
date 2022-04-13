using CreationalDesignPattern.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.AbstractFactoryDesignPattern.Implements
{
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow Meow Meow";
        }
    }
}
