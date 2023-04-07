using ZOO.Model.Animal;

namespace ZOO.Animal.Pack_animal.Donkey
{
    /// <summary>
    /// Класс ослов
    /// </summary>
    public class Donkey : Pack_animal, IClassAnimal
    {
        public Donkey(string name, DateOnly birthday) : base(name, birthday) { }
        public string ClassName => "Осел";
        public override string ToString()
        {
            return $"ID: {ID} {GetTypeAnimal() + " " + ClassName}, имя: {Name} дата рождения: {Birthday.ToString()}, знает команд: {Commands.Count}";
        }
    }
}
