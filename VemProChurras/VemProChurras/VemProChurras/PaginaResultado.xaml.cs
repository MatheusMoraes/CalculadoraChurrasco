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
        public PaginaResultado (Variaveis variaveis)
		{
			InitializeComponent ();
            variaveis.TotCarneHomem = variaveis.NumHomem * 0.5 * ((variaveis.ValorCarneBovina * 0.5) + (variaveis.ValorCarneAves*0.3) + (variaveis.ValorCarneSuina*0.2));
            variaveis.TotCarneMulher = variaveis.NumMulher * 0.35 * ((variaveis.ValorCarneBovina * 0.5) + (variaveis.ValorCarneAves * 0.3) + (variaveis.ValorCarneSuina * 0.2));
            variaveis.TotCarneCrianca = variaveis.NumCrianca * 0.15 * ((variaveis.ValorCarneBovina * 0.5) + (variaveis.ValorCarneAves * 0.3) + (variaveis.ValorCarneSuina * 0.2));
            variaveis.Total = variaveis.TotCarneCrianca + variaveis.TotCarneHomem + variaveis.TotCarneMulher;
        }

       

        private async void Inicio(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

    }
}