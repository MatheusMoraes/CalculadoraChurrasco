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
	public partial class PaginaRateio : ContentPage
	{
        public Variaveis variaveisCal;

        public PaginaRateio (Variaveis variaveis)
		{
			InitializeComponent ();
            variaveisCal = variaveis;

            variaveisCal.ValorTotCerveja = (variaveisCal.ValorCerveja * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotCaipirinha = (variaveisCal.ValorCaipirinha * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotBeats = (variaveisCal.ValorBeats * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotSuco = (variaveisCal.ValorSuco * variaveisCal.TotalDePessoas);
            variaveisCal.ValorTotVodka = (variaveisCal.ValorVodka * variaveisCal.TotalDeAdultos);
            variaveisCal.ValorTotRefrigerante = (variaveisCal.ValorRefrigerante * variaveisCal.TotalDePessoas);

            if(variaveisCal.ValorTotCerveja != 0) variaveisCal.QtdCerveja = (variaveisCal.TotalDeAdultos * 2 );
            if (variaveisCal.ValorTotCaipirinha != 0) variaveisCal.QtdCaipirinha = (variaveisCal.TotalDeAdultos * 0.5) ;
            if (variaveisCal.ValorTotBeats != 0) variaveisCal.QtdBeats = (variaveisCal.TotalDeAdultos * 2 );
            if (variaveisCal.ValorTotSuco != 0) variaveisCal.QtdSuco = (variaveisCal.TotalDePessoas * 0.5);
            if (variaveisCal.ValorTotVodka != 0) variaveisCal.QtdVodka = (variaveisCal.TotalDeAdultos * 0.25);
            if (variaveisCal.ValorTotRefrigerante != 0) variaveisCal.QtdRefrigerante = (variaveisCal.TotalDePessoas * 0.5);

            variaveisCal.TotalBebidas = (Math.Round(variaveisCal.ValorTotCerveja + variaveisCal.ValorTotCaipirinha + variaveisCal.ValorTotBeats + variaveisCal.ValorTotSuco + variaveisCal.ValorTotVodka + variaveisCal.ValorTotRefrigerante , 2));

            variaveisCal.TotalAcompanhamentos = (Math.Round((variaveisCal.ValorArrozAGrega) + (variaveisCal.ValorQueijoCoalho * variaveisCal.TotalDePessoas) + (variaveisCal.ValorFarofa) + (variaveisCal.ValorVinagrete) + (variaveisCal.ValorSaladaMaio) + (variaveisCal.ValorPao * variaveisCal.TotalDePessoas), 2));

            variaveisCal.TotalDescartaveis = (Math.Round((variaveisCal.ValorCopos + variaveisCal.ValorPratos + variaveisCal.ValorTalheres + variaveisCal.ValorCanudos + variaveisCal.ValorGuardanapos), 2));

        }

        

        private async  void Finalizar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InitialPage());
        }  

    }
}