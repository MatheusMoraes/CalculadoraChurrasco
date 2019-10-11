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


        private async void Pagina_Resultado(object sender, EventArgs e)
        {

            var variaveis = new Variaveis();

            await Navigation.PushAsync(new PaginaResultado(variaveis));


        }
	}
}