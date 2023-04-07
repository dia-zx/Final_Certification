namespace ZOO.Model.Animal.Pet.Hamster
{
    /// <summary>
    /// Класс хомяка
    /// </summary>
    public class Hamster : Pet_animal, IClassAnimal
    {
        public Hamster(string name, DateOnly birthday) : base(name, birthday) { }
        public string ClassName => "Хомяк";
        public override string ToString()
        {
            return $"ID: {ID} {GetTypeAnimal() + " " + ClassName}, имя: {Name} дата рождения: {Birthday.ToString()}, знает команд: {Commands.Count}";
        }
    }
}