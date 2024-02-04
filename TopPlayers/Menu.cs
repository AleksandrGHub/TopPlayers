namespace TopPlayers
{
    class Menu
    {
        private const string ShowPlayersByLevelCommand = "Уровень";
        private const string ShowPlayersByPowerCommand = "Сила";
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
                    case ShowPlayersByLevelCommand:
                        _catalog.ShowTopByLevel();
                        break;

                    case ShowPlayersByPowerCommand:
                        _catalog.ShowTopByPower();
                        break;
                }
            }
            while (ExitCommand == userInput == false);
        }

        private void ShowInfo()
        {
            Console.WriteLine($"************* Команды меню *************\nПоказать ТОП игроков по силе, команда: {ShowPlayersByPowerCommand}" +
                $"\nПоказать ТОП игроков по уровню, команда: {ShowPlayersByLevelCommand}\nДля выхода введите команду: {ExitCommand}\n");
        }
    }
}