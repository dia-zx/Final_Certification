using ZOO.Model.Animal;

namespace ZOO.Animal.Pack_animal
{
    /// <summary>
    /// Класс верблюда
    /// </summary>
    public class Camel : Pack_animal, IClassAnimal
    {
        public Camel(string name, DateOnly birthday) : base(name, birthday) { }
        public string ClassName => "Верблюд";
        public override string ToString()
        {
            return $"ID: {ID} {GetTypeAnimal() + " " + ClassName}, имя: {Name} дата рождения: {Birthday.ToString()}, знает команд: {Commands.Count}";
        }
    }
}
