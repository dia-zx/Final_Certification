namespace ZOO.Model.Animal
{
    public abstract class Animal
    {
        /// <summary>
        /// Имя животного
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// уникальный номер животного
        /// </summary>
        public int ID => _id;
        public DateOnly Birthday { get; set; }
        private Animal() { _id = staticID++; }
        public Animal(string name, DateOnly birthday) : base()
        {
            Name = name;
            Birthday = birthday;
        }
        public virtual string GetTypeAnimal() => "животное";

        public AnimalCommands.AnimalCommands Commands => _animalCommands;

        public override string ToString()
        {
            return $"ID: {_id} {GetTypeAnimal()}, имя: {Name} дата рождения: {Birthday.ToString()}, знает команд: {_animalCommands.Count}";
        }

        private static int staticID = 0; //используем для генерации уникального ID
        private AnimalCommands.AnimalCommands _animalCommands = new();
        private int _id;
    }
}
