namespace ZOO.View
{
    /// <summary>
    /// Графический класс взаимодействия с пользователем
    /// </summary>
    public class View
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
        public string? Input(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }
        public void Clear()
        {
            Console.Clear();
        }
    }
}
