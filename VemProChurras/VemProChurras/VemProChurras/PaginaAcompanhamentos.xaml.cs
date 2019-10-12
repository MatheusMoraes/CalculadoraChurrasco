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

        public int ValorArrozAGrega1 { get; private set; }
        public int ValorQueijoCoalho1 { get; private set; }
        public int ValorFarofa1 { get; private set; }
        public int ValorVinagrete1 { get; private set; }
        public int ValorSaladaMaio1 { get; private set; }
        public int ValorPao1 { get; private set; }

        private async void GoPaginaDescartaveis_Clicked(object sender, EventArgs e)
        {
            if (SwitchArroz.IsToggled == true) ValorArrozAGrega1 = 30;
            else ValorArrozAGrega1 = 0;

            if (SwitchQueijo.IsToggled == true) ValorQueijoCoalho1 = 30;
            else ValorQueijoCoalho1 = 0;

            if (SwitchFarofa.IsToggled == true) ValorFarofa1 = 30;
            else ValorFarofa1 = 0;

            if (SwitchVinagrete.IsToggled == true) ValorVinagrete1 = 30;
            else ValorVinagrete1 = 0;

            if (SwitchSaladaMaio.IsToggled == true) ValorSaladaMaio1 = 30;
            else ValorSaladaMaio1 = 0;

            if (SwitchPao.IsToggled == true) ValorPao1 = 30;
            else ValorPao1 = 0;

            Variaveis variaveis = new Variaveis
            {
                NumHomem = Convert.ToInt32(lblHomem.Text),
                NumMulher = Convert.ToInt32(lblMulher.Text),
                NumCrianca = Convert.ToInt32(lblCrianca.Text),
                ValorCarneAves = Convert.ToInt32(lblAves.Text),
                ValorCarneBovina = Convert.ToInt32(lblBovina.Text),
                ValorCarneSuina = Convert.ToInt32(lblSuina.Text),
                ValorCerveja = Convert.ToInt32(lblCerveja.Text),
                ValorCaipirinha = Convert.ToInt32(lblCaipirinha.Text),
                ValorBeats = Convert.ToInt32(lblBeats.Text),
                ValorSuco = Convert.ToInt32(lblSuco.Text),                
                ValorVodka = Convert.ToInt32(lblVodka.Text),
                ValorRefrigerante = Convert.ToInt32(lblRefrigerante.Text),
                ValorArrozAGrega = ValorArrozAGrega1,
                ValorQueijoCoalho = ValorQueijoCoalho1,
                ValorFarofa = ValorFarofa1,
                ValorVinagrete = ValorVinagrete1,
                ValorSaladaMaio = ValorSaladaMaio1,
                ValorPao = ValorPao1
            };

            var paginaDescartaveis = new PaginaDescartaveis();
            paginaDescartaveis.BindingContext = variaveis;
            await Navigation.PushAsync(paginaDescartaveis);


        }
    }
}