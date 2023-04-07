using ZOO.Model.Animal;

namespace ZOO.Animal.Pack_animal.Horse
{
    /// <summary>
    /// класс лошадей
    /// </summary>
    public class Horse : Pack_animal, IClassAnimal
    {
        public Horse(string name, DateOnly birthday) : base(name, birthday) { }
        public string ClassName => "Лошадь";
        public override string ToString()
        {
            return $"ID: {ID} {GetTypeAnimal() + " " + ClassName}, имя: {Name} дата рождения: {Birthday.ToString()}, знает команд: {Commands.Count}";
        }
    }
}
