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
	public partial class PaginaDeCarnes : ContentPage
	{
		public PaginaDeCarnes ()
		{
			InitializeComponent ();
            
		}


        private async void PaginaBebida(object sender, EventArgs e)
        {
            var variaveis = new Variaveis
            {

                CarneAves = SwitchAves.IsToggled.Equals(30)
            };
            var pagBebidas = new PaginaBebidas();
            pagBebidas.BindingContext = variaveis;
            await Navigation.PushAsync(pagBebidas);
        }


	}
}