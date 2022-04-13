using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Implements
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark Bark";
        }

    }
}
