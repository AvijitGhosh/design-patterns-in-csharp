using CreationalDesignPattern.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.AbstractFactoryDesignPattern.Implements
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
