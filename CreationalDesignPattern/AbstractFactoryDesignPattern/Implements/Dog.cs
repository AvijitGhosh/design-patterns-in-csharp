using CreationalDesignPattern.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.AbstractFactoryDesignPattern.Implements
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark Bark";
        }

    }
}
