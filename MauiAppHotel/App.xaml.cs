using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public static List<Quarto> lista_quartos = new()
        {
            new ()
            {
                Descricao = "Suíte Super Luxo",
                ValorDiarioAdulto = 110.0,
                ValorDiarioCrianca = 55.0
            },
            new ()
            {
                Descricao = "Suíte Luxo",
                ValorDiarioAdulto = 80.0,
                ValorDiarioCrianca = 40.0
            },
            new () {
                Descricao = "Suíte Single",
                ValorDiarioAdulto = 50.0,
                ValorDiarioCrianca = 25.0
            },
            new () {
                Descricao = "Suíte Crise",
                ValorDiarioAdulto = 25.0,
                ValorDiarioCrianca = 12.5
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}
