namespace TopPlayers
{
    class Catalog
    {
        private Random _random = new Random();
        private List<Player> _players = new List<Player>();
        private List<Player> _topPlayers = new List<Player>();

        public Catalog()
        {
            AddPlayers();
        }

        public void ShowPlayers()
        {
            Console.WriteLine("Список игроков.");
            Show(_players);
        }

        public void ShowTopPlayers()
        {
            if (_topPlayers.Count > 0)
            {
                Console.WriteLine("Список ТОП трёх игроков.");
                Show(_topPlayers);
            }
            else
            {
                Console.WriteLine("Список ТОП трёх игроков пустой.\nНажмите любую клавишу.");
            }

            Console.ReadKey();
        }

        public void SelectPlayers()
        {
            int countChoices = 3;

            _topPlayers = _players.OrderByDescending(player => player.Level).Take(countChoices).Concat(_players.OrderByDescending(player => player.Power).Take(countChoices)).ToList();

            Console.WriteLine("Список ТОП трёх игроков Отобран.\nНажмите любую клавишу.");

            Console.ReadKey();
        }

        private void Show(List<Player> players)
        {
            foreach (var player in players)
            {
                player.ShowInfo();
            }

            Console.WriteLine();
        }

        private void AddPlayers()
        {
            int numberPlayers = 20;
            int maxLevel = 100;
            int minPower = 40;
            int maxPower = 90;

            List<string> names = new List<string>() { "Сергей","Дмитрий","Андрей","Алексей","Максим","Иван","Роман","Евгений","Михаил","Артем",
                "Анастасия","Мария","Анна","Виктория","Екатерина","Наталья","Марина","Полина","София","Дарья","Алиса","Ксения","Александра","Елена"};

            for (int i = 0; i < numberPlayers; i++)
            {
                _players.Add(new Player(names[_random.Next(names.Count)], _random.Next(maxLevel), _random.Next(minPower, maxPower)));
            }
        }
    }
}