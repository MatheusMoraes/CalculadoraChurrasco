using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VemProChurras.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VemProChurras
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaCortes : ContentPage
	{
		public PaginaCortes ()
		{
			InitializeComponent ();
		}
        private async void Pagina_Boi(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaBoi());
        }


        private async void Pagina_Galinha(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaGalinha());

        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Pagina_Porco(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaPorco());
        }
    }
}