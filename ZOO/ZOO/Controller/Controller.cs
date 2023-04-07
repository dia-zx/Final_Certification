using ZOO.Animal.Pack_animal;
using ZOO.Animal.Pack_animal.Donkey;
using ZOO.Animal.Pack_animal.Horse;
using ZOO.Model.Animal;
using ZOO.Model.Animal.Pet.Cat;
using ZOO.Model.Animal.Pet.Dog;
using ZOO.Model.Animal.Pet.Hamster;
using ZOO.Model.AnimalsDB;

namespace ZOO.Controller
{
    internal class Controller
    {
        public Controller(View.View view, AnimalsDB animalsDB)
        {

            _view = view;
            _animalsDB = animalsDB;

        }

        public void Start()
        {
            do
            {
                _view.Clear();
                _view.Print("**************** Меню ********************");
                _view.Print("1 - Вывод списка животных БД");
                _view.Print("2 - Добавление нового животного");
                _view.Print("3 - Список команд животного");
                _view.Print("4 - Обучение новой команде");
                _view.Print("0 - выход");
                _view.Print("******************************************");
                string input = _view.Input("введите номер пункта меню:");

                switch (input)
                {
                    case "1": Menu_AnimalsList(); break;
                    case "2": Menu_AnimalAdd(); break;
                    case "3": Menu_AnimalCommandList(); break;
                    case "4": Menu_AnimalNewCommand(); break;
                    case "0": return;
                }


                _view.Input("Нажмите < Enter > для продолжения");
            } while (true);
        }

        /// <summary>
        /// Обучение новой команде
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Menu_AnimalNewCommand()
        {
            string input_id = _view.Input("Введите ID животного:");
            int id;
            try
            {
                id = int.Parse(input_id);
            }
            catch (Exception ex)
            {
                _view.Print("Неправильный ввод!"); return;
            }

            Model.Animal.Animal animal;
            try
            {
                animal = _animalsDB.GetAnimal(id);
            }
            catch (Exception ex)
            {
                _view.Print(ex.Message);
                return;
            }

            string input_command_name = _view.Input("Введите название команды:");
            string input_command_action = _view.Input("Введите действие команды:");

            try
            {
                animal.Commands.Add(new Model.AnimalCommands.AnimalCommand(input_command_name, input_command_action));
            }
            catch (Exception ex)
            {
                _view.Print(ex.Message);
                return;
            }
        }

        /// <summary>
        /// Вывод команд которые знает животное
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void Menu_AnimalCommandList()
        {
            string input_id = _view.Input("Введите ID животного:");
            int id;
            try
            {
                id = int.Parse(input_id);
            }catch (Exception ex)
            {
                _view.Print("Неправильный ввод!"); return;
            }

            Model.Animal.Animal animal;
            try
            {
                animal = _animalsDB.GetAnimal(id);
            }catch(Exception ex) {
                _view.Print(ex.Message);
                return;
            }

            foreach (var it in animal.Commands.GetCommands())
                _view.Print($"{it.Name} - {it.Action}");

        }

        /// <summary>
        /// Создание нового животного
        /// </summary>
        private void Menu_AnimalAdd()
        {
            _view.Print("1 - Верблюд,  2 - Осел,  3 - Лошадь  4 - Кошка, 5 - Собака, 6 - Хомяк, 0 - отмена");
            string input_type = _view.Input("Введите создаваемый тип животного:");
            string input_name = _view.Input("Введите имя животного:");
            string input_birthday = _view.Input("Введите День рождения в формате (дд.мм.гггг):");
            DateOnly birthday;
            try
            {
                birthday = DateOnly.Parse(input_birthday);
            }
            catch (Exception e)
            {
                _view.Print("Неверная дата..");
                return;
            }

            try
            {
                switch (input_type)
                {
                    case "0": return;
                    case "1": _animalsDB.Add(new Camel(input_name, birthday)); break;
                    case "2": _animalsDB.Add(new Donkey(input_name, birthday)); break;
                    case "3": _animalsDB.Add(new Horse(input_name, birthday)); break;
                    case "4": _animalsDB.Add(new Cat(input_name, birthday)); break;
                    case "5": _animalsDB.Add(new Dog(input_name, birthday)); break;
                    case "6":
                        _animalsDB.Add(new Hamster(input_name, birthday)); break;
                        _view.Print("Неправильный ввод!"); return;


                }
            }
            catch (Exception e)
            {
                _view.Print(e.Message);
                return;
            }
            _view.Print("Новое животное создано!");
        }

        /// <summary>
        /// Вывод списка животных
        /// </summary>
        private void Menu_AnimalsList()
        {
            _view.Print("");
            _view.Print($"Всего записей в БД: {_animalsDB.Count()}");
            foreach (var it in _animalsDB.GetAnimalsList())
                _view.Print(it.ToString());
        }



        private View.View _view;
        private AnimalsDB _animalsDB;
    }
}
