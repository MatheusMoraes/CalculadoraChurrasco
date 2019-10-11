using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VemProChurras
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaDeCarnes : ContentPage
    {
        public PaginaDeCarnes()
        {
            InitializeComponent();

        }

        public int ValorCarneBovina1 { get; private set; }
        public int ValorCarneAves1 { get; private set; }
        public int ValorCarneSuino1 { get; private set; }

        private async void PaginaBebidas(object sender, EventArgs e)
        {
            if (SwitchBovina.IsToggled == true) ValorCarneBovina1 = 30;
            else ValorCarneBovina1 = 0;

            if (SwitchAves.IsToggled == true) ValorCarneAves1 = 30;
            else ValorCarneAves1 = 0;

            if (SwitchSuino.IsToggled == true) ValorCarneSuino1 = 30;
            else ValorCarneSuino1 = 0;

            Variaveis variaveis = new Variaveis
            {
                NumHomem = Convert.ToInt32(lblHomem.Text),
                NumMulher = Convert.ToInt32(lblMulher.Text),
                NumCrianca = Convert.ToInt32(lblCrianca.Text),
                ValorCarneAves = ValorCarneAves1,
                ValorCarneBovina = ValorCarneBovina1,
                ValorCarneSuina = ValorCarneSuino1
            };
            var paginaBebidas = new PaginaBebidas();
            paginaBebidas.BindingContext = variaveis;
            await Navigation.PushAsync(paginaBebidas);
        }
    }
}