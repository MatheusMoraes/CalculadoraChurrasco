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

            variaveisCal.ValorTotCarneBovina = (Math.Round((variaveisCal.TotalDeCarnes * 0.5),2));
            variaveisCal.ValorTotCarneAves = (Math.Round((variaveisCal.TotalDeCarnes * 0.3),2));
            variaveisCal.ValorTotCarneSuina = (Math.Round((variaveisCal.TotalDeCarnes * 0.2),2));

            variaveisCal.TotKgCarneBovina = (Math.Round(variaveisCal.ValorTotCarneBovina / 30, 2));
            variaveisCal.TotKgCarneAve = (Math.Round(variaveisCal.ValorTotCarneAves / 25, 2));
            variaveisCal.TotKgCarneSuina = (Math.Round(variaveisCal.ValorTotCarneSuina / 27, 2));

            variaveisCal.TotKgCarne = (Math.Round((variaveisCal.TotKgCarneBovina + variaveisCal.TotKgCarneAve + variaveisCal.TotKgCarneSuina), 2));

            variaveisCal.ValorTotCerveja = (variaveisCal.ValorCerveja * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotCaipirinha = (variaveisCal.ValorCaipirinha * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotBeats = (variaveisCal.ValorBeats * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotSuco = (variaveisCal.ValorSuco * variaveisCal.TotalDePessoas);
            variaveisCal.ValorTotVodka = (variaveisCal.ValorVodka * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotRefrigerante = (variaveisCal.ValorRefrigerante * variaveisCal.TotalDePessoas);

            if (variaveisCal.ValorTotCerveja != 0) variaveisCal.QtdCerveja = (variaveisCal.TotalDeAdultos * 3);
            if (variaveisCal.ValorTotCaipirinha != 0) variaveisCal.QtdCaipirinha = (variaveisCal.TotalDeAdultos * 0.5);
            if (variaveisCal.ValorTotBeats != 0) variaveisCal.QtdBeats = (variaveisCal.TotalDeAdultos * 2);
            if (variaveisCal.ValorTotSuco != 0) variaveisCal.QtdSuco = (variaveisCal.TotalDePessoas * 0.5);
            if (variaveisCal.ValorTotVodka != 0) variaveisCal.QtdVodka = (variaveisCal.TotalDeAdultos * 0.25);
            if (variaveisCal.ValorTotRefrigerante != 0) variaveisCal.QtdRefrigerante = (variaveisCal.TotalDePessoas * 0.5);

            variaveisCal.TotalBebidas = (Math.Round(variaveisCal.ValorTotCerveja + variaveisCal.ValorTotCaipirinha + variaveisCal.ValorTotBeats + variaveisCal.ValorTotSuco + variaveisCal.ValorTotVodka + variaveisCal.ValorTotRefrigerante, 2));

            variaveisCal.ValorTotQueijoCoalho = variaveisCal.ValorQueijoCoalho * variaveisCal.TotalDePessoas;
            variaveisCal.ValorTotPao = variaveisCal.ValorPao * variaveisCal.TotalDePessoas;

            if (variaveisCal.ValorTotQueijoCoalho != 0) variaveisCal.QtdQueijoCoalho = (variaveisCal.TotalDePessoas * 2);
            if (variaveisCal.ValorTotPao != 0) variaveisCal.QtdPao = (variaveisCal.TotalDePessoas * 1);

            variaveisCal.TotalAcompanhamentos = (Math.Round((variaveisCal.ValorArrozAGrega) + (variaveisCal.ValorTotQueijoCoalho) + (variaveisCal.ValorFarofa) + (variaveisCal.ValorVinagrete) + (variaveisCal.ValorSaladaMaio) + (variaveisCal.ValorTotPao), 2));

            variaveisCal.TotalDescartaveis = (Math.Round((variaveisCal.ValorCopos + variaveisCal.ValorPratos + variaveisCal.ValorTalheres + variaveisCal.ValorCanudos + variaveisCal.ValorGuardanapos), 2));

           
            variaveisCal.Total = (Math.Round((variaveisCal.TotalDeCarnes + variaveisCal.TotalBebidas + variaveisCal.TotalAcompanhamentos + variaveisCal.TotalDescartaveis),2));
        }

      

        private async void PaginaRateio(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new PaginaRateio(variaveisCal));

        }

    }
}