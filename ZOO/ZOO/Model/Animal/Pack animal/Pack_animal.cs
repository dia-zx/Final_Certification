namespace ZOO.Animal.Pack_animal
{
    public abstract class Pack_animal : ZOO.Model.Animal.Animal
    {
        public Pack_animal(string name, DateOnly birthday) : base(name, birthday) { }
        public override string GetTypeAnimal() => "вьючное животное";
    }
}
