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
        public double Rateio;


        public PaginaRateio (Variaveis variaveis)
		{
			InitializeComponent ();
            variaveisCal = variaveis;

           

            


        }

        
        
        private async  void Finalizar(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }


        private void CalcularRateio(object sender, EventArgs e)
        {
            var a = new PaginaResultado(variaveisCal);

            if (Convert.ToInt32(EntryRateio.Text) <= a.variaveisCal.TotalDePessoas)
            {
             Rateio = a.variaveisCal.Total / Convert.ToInt32(EntryRateio.Text);
                bxv_Rateio.IsVisible = true;

                lbl_Rateio.Text =Convert.ToString($"{ Math.Round((Rateio),2)}");
                lbl_Titulo.Text = "Preço Unitário (R$): ";
              
            }

            else
            {
                DisplayAlert("ATENÇÃO", "O número de pessoas do rateio é maior que o número de participantes", "OK");
            }

        }

        
    }
}