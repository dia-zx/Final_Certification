namespace ZOO.Model.AnimalsDB
{
    public class AnimalsDB
    {
        /// <summary>
        /// Очистка БД
        /// </summary>
        public void Clear() => _DB.Clear();
        /// <summary>
        /// Добавление животного
        /// </summary>
        /// <param name="animal"></param>
        public void Add(Animal.Animal animal)
        {
            if (animal == null) return;
            _DB.Add(animal.ID, animal);
        }

        /// <summary>
        /// получение животного по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Animal.Animal GetAnimal(int id)
        {
            if(_DB.ContainsKey(id)) return _DB[id];
            throw new Exception("Неверный id");
        }

        /// <summary>
        /// Всего записей
        /// </summary>
        /// <returns></returns>
        public int Count() => _DB.Count;

        /// <summary>
        /// Получение списка животных
        /// </summary>
        /// <returns></returns>
        public List<Animal.Animal> GetAnimalsList() => _DB.Values.ToList();

        private Dictionary<int, Animal.Animal> _DB = new();
    }
}
