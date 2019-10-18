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

            variaveisCal.TotalDeAdultos = variaveisCal.NumMulher + variaveisCal.NumHomem;

            variaveisCal.TotalDePessoas = variaveisCal.TotalDeAdultos + variaveisCal.NumCrianca;

            variaveisCal.TotalDeCarnes =(Math.Round((variaveisCal.TotCarneHomem + variaveisCal.TotCarneMulher + variaveisCal.TotCarneCrianca),2));

            variaveisCal.TotalBebidas = (Math.Round((variaveisCal.ValorCerveja * variaveisCal.TotalDeAdultos) + (variaveisCal.ValorCaipirinha * variaveisCal.TotalDeAdultos) + (variaveisCal.ValorBeats * variaveisCal.TotalDeAdultos) + (variaveisCal.ValorSuco * variaveisCal.TotalDePessoas) + (variaveisCal.ValorVodka * variaveisCal.TotalDeAdultos) + (variaveisCal.ValorRefrigerante * variaveisCal.TotalDePessoas),2));

            variaveisCal.TotalAcompanhamentos = (Math.Round((variaveisCal.ValorArrozAGrega) + (variaveisCal.ValorQueijoCoalho * variaveisCal.TotalDePessoas) + (variaveisCal.ValorFarofa) + (variaveisCal.ValorVinagrete) + (variaveisCal.ValorSaladaMaio) + (variaveisCal.ValorPao * variaveisCal.TotalDePessoas),2));

            variaveisCal.TotalDescartaveis = (Math.Round((variaveisCal.ValorCopos + variaveisCal.ValorPratos + variaveisCal.ValorTalheres + variaveisCal.ValorCanudos + variaveisCal.ValorGuardanapos),2));

            variaveisCal.TotVlCarneBovina = (variaveisCal.TotalDeCarnes * 0.5) ;
            variaveisCal.TotVlCarneAve = (variaveisCal.TotalDeCarnes * 0.3) ;
            variaveisCal.TotVlCarneSuina = (variaveisCal.TotalDeCarnes * 0.2);

            variaveisCal.TotKgCarneBovina = variaveisCal.TotVlCarneBovina / 30;
            variaveisCal.TotKgCarneAve = variaveisCal.TotVlCarneAve / 25 ;
            variaveisCal.TotKgCarneSuina = variaveisCal.TotVlCarneSuina / 27;



            // //bebidas
            //variaveisCal.ValorCerveja = ;
            //variaveisCal.ValorCaipirinha = ;
            //variaveisCal.ValorBeats = ;
            //variaveisCal.ValorSuco = ;
            //variaveisCal.ValorVodka = ;
            //variaveisCal.ValorRefrigerante = ;
            // //acompanhamentos
            //variaveisCal.ValorArrozAGrega = ;
            //variaveisCal.ValorQueijoCoalho = ;
            //variaveisCal.ValorFarofa = ;
            //variaveisCal.ValorVinagrete = ;
            //variaveisCal.ValorSaladaMaio = ;
            //variaveisCal.ValorPao = ;
            // //descartaveis
            //variaveisCal.ValorCopos = ;
            //variaveisCal.ValorPratos = ;
            //variaveisCal.ValorTalheres = ;
            //variaveisCal.ValorCanudos = ;
            //variaveisCal.ValorGuardanapos = ;

            variaveisCal.Total = (Math.Round((variaveisCal.TotalDeCarnes + variaveisCal.TotalBebidas + variaveisCal.TotalAcompanhamentos + variaveisCal.TotalDescartaveis),2));
        }

        private async void Inicio(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void PaginaRateio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaRateio(variaveisCal));

        }

    }
}