using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Shapes;
using WpfApp1.Controllers;
using WpfApp1.Model;
using WpfApp1.Services;
using YourNamespace.Reports;


namespace WpfApp1.ViewModel
{
    internal class vmMainWindow: INotifyPropertyChanged
    {

        #region logical attributes

        private readonly object _lockInstance = new object();

        protected readonly object _lockTO = new object();

        private Task _runningTask;

        private CancellationTokenSource _cancelTask;
        private static CancellationTokenSource _cts = new CancellationTokenSource();

        #endregion

        #region private attributes
        private ObservableCollection<Player> _players;
        private ObservableCollection<Player> _topPlayers;
        private string _countdown;

        PlayerController _playerController = new PlayerController();
        RandomizeController _randomController = new RandomizeController();

        #endregion

        #region public attributes
        public ObservableCollection<Player> Players
        {
            get => _players;
            set
            {
                if (_players != value)
                {
                    _players = value;
                    OnPropertyChanged(nameof(Players)); 
                }
            }
        }

        public ObservableCollection<Player> TopPlayers
        {
            get => _topPlayers;
            set
            {
                if (_topPlayers != value)
                {
                    _topPlayers = value;
                    OnPropertyChanged(nameof(TopPlayers)); 
                }
            }
        }

        public string Countdown
        {
            get => _countdown;
            set
            {
                if (_countdown != value)
                {
                    _countdown = value;
                    OnPropertyChanged(nameof(Countdown));
                }
            }
        }

        #endregion

        public vmMainWindow()
        {
            FillLists();
            _cts = new CancellationTokenSource();

            _ = StartCronJob(); 
        }

        private async Task StartCronJob()
        {
            try
            {
                await RunCronJobAsync(_cts.Token);
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("El cron job fue cancelado.");
            }
        }

        private async Task RunCronJobAsync(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                int secondsRemaining = 5 * 60;

                while (secondsRemaining > 0 && !token.IsCancellationRequested)
                {
                    TimeSpan timeSpan = TimeSpan.FromSeconds(secondsRemaining);
                    Countdown = timeSpan.ToString(@"mm\:ss");
                    await Task.Delay(1000, token);
                    secondsRemaining--;
                }

                if (!token.IsCancellationRequested)
                {

                    for (int i = 0; i < RandomNum(10); i++)
                    {
                        await CreatePlayers();
                    }
                    FillLists();
                    Countdown = "00:00";
                }
            }
        }


        public void StopCronJob()
        {
            _cts?.Cancel(); 
        }

        void FillLists()
        {
            Players = new ObservableCollection<Player>(_playerController.GetPlayers(null));
            TopPlayers = new ObservableCollection<Player>(_playerController.GetPlayers(10));

        }

        async Task CreatePlayers()
        {
           RandomUser random = await _randomController.GetRandomUser();

            Player player = new Player(null,random.Name.First + random.Name.Last, random.Picture.Large);

            player.SetScore(RandomNum(100)); 

            _playerController.InsertPlayer(player);
        }

        public int RandomNum(int max)
        {
            if (max < 0)
                throw new ArgumentOutOfRangeException(nameof(max), "El número máximo debe ser mayor o igual a 0.");

            Random random = new Random();
            return random.Next(0, max + 1);
        }

        public void Report()
        {
            var players = _playerController.GetPlayers(10);

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string directoryPath = System.IO.Path.Combine(baseDirectory, "Reports", "Generated");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = System.IO.Path.Combine(directoryPath, "players_report.csv");

            ReportGenerator.GenerateCsv(players, filePath);

            Console.WriteLine($"Reporte generado en: {filePath}");
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    } 
}
