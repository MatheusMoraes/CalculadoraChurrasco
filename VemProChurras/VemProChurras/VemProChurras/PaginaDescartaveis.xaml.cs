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
	public partial class PaginaDescartaveis : ContentPage
	{
		public PaginaDescartaveis ()
		{
			InitializeComponent ();
		}


        public int ValorCopos1 { get; private set; }
        public int ValorPratos1 { get; private set; }
        public int ValorTalheres1 { get; private set; }
        public int ValorCanudos1 { get; private set; }
        public int ValorGuardanapos1 { get; private set; }

        private async void Pagina_Resultado(object sender, EventArgs e)
        {
            if (SwitchCopos.IsToggled == true) ValorCopos1 = 30;
            else ValorCopos1 = 0;

            if (SwitchPratos.IsToggled == true) ValorPratos1 = 30;
            else ValorPratos1 = 0;

            if (SwitchTalheres.IsToggled == true) ValorTalheres1 = 30;
            else ValorTalheres1 = 0;

            if (SwitchCanudos.IsToggled == true) ValorCanudos1 = 30;
            else ValorCanudos1 = 0;

            if (SwitchGuardanapos.IsToggled == true) ValorGuardanapos1 = 30;
            else ValorGuardanapos1 = 0;

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
                ValorArrozAGrega = Convert.ToInt32(lblArrozAGrega.Text),
                ValorQueijoCoalho = Convert.ToInt32(lblQueijoCoalho.Text),
                ValorFarofa = Convert.ToInt32(lblFarofa.Text),
                ValorVinagrete = Convert.ToInt32(lblVinagrete.Text),
                ValorSaladaMaio = Convert.ToInt32(lblSaladaMaio.Text),
                ValorPao = Convert.ToInt32(lblPao.Text),
                ValorCopos = ValorCopos1,
                ValorPratos = ValorPratos1,
                ValorTalheres = ValorTalheres1,
                ValorCanudos = ValorCanudos1,
                ValorGuardanapos = ValorGuardanapos1
            };

            var paginaResultado = new PaginaResultado(variaveis);
            paginaResultado.BindingContext = variaveis;
            await Navigation.PushAsync(paginaResultado);

        }
	}
}