using CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Interface;

namespace CreationalDesignPattern.Factory.AbstractFactoryDesignPattern.Implements
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
