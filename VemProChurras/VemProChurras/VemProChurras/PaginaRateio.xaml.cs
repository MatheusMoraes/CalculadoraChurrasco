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
            

        }

        

        private async  void Finalizar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InitialPage());
        }  

    }
}