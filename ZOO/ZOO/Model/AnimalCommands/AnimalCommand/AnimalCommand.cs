namespace ZOO.Model.AnimalCommands
{
    public struct AnimalCommand
    {
        /// <summary>
        /// Название команды, которую выполняет животное
        /// </summary>
        public readonly string Name => _name;

        /// <summary>
        /// Действие на команду
        /// </summary>
        public readonly string Action => _action;


        public AnimalCommand(string name, string action)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentException("Неверное название команды!");
            if (string.IsNullOrEmpty(action)) throw new ArgumentException("Неверная команда!");
            _name = name;
            _action = action;
        }

        public override string ToString() => _action;


        private string _name;
        private string _action;
    }
}
