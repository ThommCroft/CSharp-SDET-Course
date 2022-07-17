using OOPApp.Interfaces;

namespace OOPApp
{
    public class BaseAnimal : IMoveable, IEatable // Base Class with Interfaces
    {
        private string _name = "";

        private string _animalType = "";

        public string Name { get { return _name; } }
        public string AnimalType { get { return _animalType; } }

        public BaseAnimal()
        {

        }

        public BaseAnimal(string name, string animalType)
        {
            _name = name;
            _animalType = animalType;
        }

        public virtual string Move()
        {
            return "Walking";
        }

        public virtual string Eat(string food)
        {
            return food;
        }
    }
}
