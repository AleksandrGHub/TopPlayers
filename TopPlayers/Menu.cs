namespace TopPlayers
{
    class Menu
    {
        private const string SelectPlayersComand = "Отобрать";
        private const string ShowPlayersCommand = "Показать";
        private const string ExitCommand = "Выход";

        private Catalog _catalog = new Catalog();

        public void Work()
        {
            string userInput;

            do
            {
                Console.Clear();
                ShowInfo();
                _catalog.ShowPlayers();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case SelectPlayersComand:
                        _catalog.SelectPlayers();
                        break;

                    case ShowPlayersCommand:
                        _catalog.ShowTopPlayers();
                        break;
                }
            }
            while (ExitCommand == userInput == false);
        }

        private void ShowInfo()
        {
            Console.WriteLine($"************* Команды меню *************\nВыбрать ТОП игроков, команда: {SelectPlayersComand}" +
                $"\nПоказать ТОП игроков, команда: {ShowPlayersCommand}\nДля выхода введите команду: {ExitCommand}\n");
        }
    }
}