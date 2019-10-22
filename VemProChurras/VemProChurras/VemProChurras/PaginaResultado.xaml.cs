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
	public partial class PaginaResultado : ContentPage
	{

        public Variaveis variaveisCal;

        public PaginaResultado (Variaveis variaveis)
		{
			InitializeComponent ();
            variaveisCal = variaveis;
            Calculo();

        }

        public void Calculo()
        {
            variaveisCal.TotCarneHomem = variaveisCal.NumHomem * 0.5 * ((variaveisCal.ValorCarneBovina * 0.5) + (variaveisCal.ValorCarneAves * 0.3) + (variaveisCal.ValorCarneSuina * 0.2));
            variaveisCal.TotCarneMulher = variaveisCal.NumMulher * 0.35 * ((variaveisCal.ValorCarneBovina * 0.5) + (variaveisCal.ValorCarneAves * 0.3) + (variaveisCal.ValorCarneSuina * 0.2));
            variaveisCal.TotCarneCrianca = variaveisCal.NumCrianca * 0.15 * ((variaveisCal.ValorCarneBovina * 0.5) + (variaveisCal.ValorCarneAves * 0.3) + (variaveisCal.ValorCarneSuina * 0.2));
            variaveisCal.Total = variaveisCal.TotCarneCrianca + variaveisCal.TotCarneHomem + variaveisCal.TotCarneMulher;

            
        }


        private async void Inicio(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void PaginaRateio(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new PaginaRateio());
        }
    }
}