namespace ZOO.Model.Animal.Pet.Dog
{
    /// <summary>
    /// Класс собаки
    /// </summary>
    public class Dog : Pet_animal, IClassAnimal
    {
        public Dog(string name, DateOnly birthday) : base(name, birthday) { }
        public string ClassName => "Собака";
        public override string ToString()
        {
            return $"ID: {ID} {GetTypeAnimal() + " " + ClassName}, имя: {Name} дата рождения: {Birthday.ToString()}, знает команд: {Commands.Count}";
        }
    }
}