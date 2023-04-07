namespace ZOO.Model.AnimalCommands
{
    public class AnimalCommands
    {

        /// <summary>
        /// Очистка списка команд
        /// </summary>
        public void Clear() => _commands.Clear();

        /// <summary>
        /// Добавление новой команды в список
        /// </summary>
        /// <param name="command">добавляемая команда</param>
        /// <exception cref="ArgumentException"> если такая команда уже есть!</exception>
        public void Add(AnimalCommand command)
        {
            if (_commands.ContainsKey(command.Name)) throw new ArgumentException("Такая команда уже есть!");
            _commands[command.Name] = command;
        }

        /// <summary>
        /// удаление команды
        /// </summary>
        /// <param name="command_name"></param>
        public void Remove(string command_name)
        {
            if (!_commands.ContainsKey(command_name)) return; //нет в списке
            _commands.Remove(command_name);

        }

        /// <summary>
        /// Получение списка имен команд
        /// </summary>
        /// <returns>список имен команд</returns>
        public List<string> GetNames() => _commands.Keys.ToList();

        /// <summary>
        /// получение списка команд
        /// </summary>
        /// <returns></returns>
        public List<AnimalCommand> GetCommands() => _commands.Values.ToList();

        /// <summary>
        /// Получение команды по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public AnimalCommand GetCommand(string name)
        {
            if (!_commands.ContainsKey(name)) throw new ArgumentException("Такой команды нет!");
            return _commands[name];
        }

        /// <summary>
        /// количество команд в списке
        /// </summary>
        public int Count => _commands.Count;


        private Dictionary<string, AnimalCommand> _commands = new();
    }
}
