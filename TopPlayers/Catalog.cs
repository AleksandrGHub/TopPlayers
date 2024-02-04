namespace TopPlayers
{
    class Catalog
    {
        private Random _random = new Random();
        private List<Player> _players = new List<Player>();
        private int _countChoices = 3;


        public Catalog()
        {
            AddPlayers();
        }

        public void ShowTopByPower()
        {
            Console.WriteLine($"Список ТОП-{_countChoices} игроков по силе.");

            Show(_players.OrderByDescending(player => player.Power).Take(_countChoices).ToList());

            Console.ReadKey();
        }

        public void ShowTopByLevel()
        {
            Console.WriteLine($"Список ТОП-{_countChoices} игроков по уровню.");

            Show(_players.OrderByDescending(player => player.Level).Take(_countChoices).ToList());

            Console.ReadKey();
        }

        public void ShowPlayers()
        {
            Show(_players);
        }

        private void Show(List<Player> players)
        {
            foreach (var player in players)
            {
                player.ShowInfo();
            }
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