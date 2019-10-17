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


        public double ValorCopos1 { get; private set; }
        public double ValorPratos1 { get; private set; }
        public double ValorTalheres1 { get; private set; }
        public double ValorCanudos1 { get; private set; }
        public double ValorGuardanapos1 { get; private set; }

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
                NumHomem = Convert.ToDouble(lblHomem.Text),
                NumMulher = Convert.ToDouble(lblMulher.Text),
                NumCrianca = Convert.ToDouble(lblCrianca.Text),
                ValorCarneAves = Convert.ToDouble(lblAves.Text),
                ValorCarneBovina = Convert.ToDouble(lblBovina.Text),
                ValorCarneSuina = Convert.ToDouble(lblSuina.Text),
                ValorCerveja = Convert.ToDouble(lblCerveja.Text),
                ValorCaipirinha = Convert.ToDouble(lblCaipirinha.Text),
                ValorBeats = Convert.ToDouble(lblBeats.Text),
                ValorSuco = Convert.ToDouble(lblSuco.Text),
                ValorVodka = Convert.ToDouble(lblVodka.Text),
                ValorRefrigerante = Convert.ToDouble(lblRefrigerante.Text),
                ValorArrozAGrega = Convert.ToDouble(lblArrozAGrega.Text),
                ValorQueijoCoalho = Convert.ToDouble(lblQueijoCoalho.Text),
                ValorFarofa = Convert.ToDouble(lblFarofa.Text),
                ValorVinagrete = Convert.ToDouble(lblVinagrete.Text),
                ValorSaladaMaio = Convert.ToDouble(lblSaladaMaio.Text),
                ValorPao = Convert.ToDouble(lblPao.Text),
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