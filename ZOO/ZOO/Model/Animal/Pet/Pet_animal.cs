namespace ZOO.Model.Animal.Pet
{
    public abstract class Pet_animal : Animal
    {
        public Pet_animal(string name, DateOnly birthday) :base(name, birthday) { }
        public override string GetTypeAnimal() => "домашнее животное";

    }
}
