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
	public partial class PaginaAcompanhamentos : ContentPage
	{
		public PaginaAcompanhamentos ()
		{
			InitializeComponent ();
		}

        private async void GoPaginaDescartaveis_Clicked(object sender, EventArgs e)
        {
            if (SwitchCerveja.IsToggled == true) ValorCerveja1 = 30;
            else ValorCerveja1 = 0;

            if (SwitchCaipirinha.IsToggled == true) ValorCaipirinha1 = 30;
            else ValorCaipirinha1 = 0;

            if (SwitchBeats.IsToggled == true) ValorBeats1 = 30;
            else ValorBeats1 = 0;
            if (SwitchSuco.IsToggled == true) ValorSuco1 = 30;
            else ValorSuco1 = 0;

            if (SwitchVodka.IsToggled == true) ValorVodka1 = 30;
            else ValorVodka1 = 0;

            if (SwitchRefrigerante.IsToggled == true) ValorRefrigerante1 = 30;
            else ValorRefrigerante1 = 0;

            Variaveis variaveis = new Variaveis
            {
                NumHomem = Convert.ToInt32(lblHomem.Text),
                NumMulher = Convert.ToInt32(lblMulher.Text),
                NumCrianca = Convert.ToInt32(lblCrianca.Text),
                ValorCarneAves = Convert.ToInt32(lblAves.Text),
                ValorCarneBovina = Convert.ToInt32(lblBovina.Text),
                ValorCarneSuina = Convert.ToInt32(lblSuina.Text),
                ValorCerveja = Convert.ToInt32(lblSuina.Text),
                ValorCaipirinha = Convert.ToInt32(lblSuina.Text),
                ValorBeats = Convert.ToInt32(lblSuina.Text),
                ValorSuco = Convert.ToInt32(lblSuina.Text),
                ValorVodka = Convert.ToInt32(lblSuina.Text),
                ValorRefrigerante = Convert.ToInt32(lblSuina.Text),

            };
            var paginaDescartaveis = new PaginaDescartaveis();
            paginaDescartaveis.BindingContext = variaveis;
            await Navigation.PushAsync(paginaDescartaveis);


        }
    }
}