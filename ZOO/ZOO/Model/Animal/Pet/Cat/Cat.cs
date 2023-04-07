namespace ZOO.Model.Animal.Pet.Cat
{
    /// <summary>
    /// Класс кошки
    /// </summary>
    public class Cat : Pet_animal, IClassAnimal
    {
        public Cat(string name, DateOnly birthday) : base(name, birthday) { }
        public string ClassName => "Кошка";
        public override string ToString()
        {
            return $"ID: {ID} {GetTypeAnimal() + " " + ClassName}, имя: {Name} дата рождения: {Birthday.ToString()}, знает команд: {Commands.Count}";
        }
    }
}
