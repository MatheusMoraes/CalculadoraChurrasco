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
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();

            Detail = new NavigationPage(new InitialPage()) { BarBackgroundColor = Color.FromRgb(243, 123, 74) };
            NavigationPage.SetHasNavigationBar(this, false);

		}

        private async void Cortes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaCortes());
        }

        private async void Pessoas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new People());
        }


        private async void TiposDeCarne(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaDeCarnes());
        }

        private async void Acompanhamentos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaAcompanhamentos());
        }

        private async void Bebidas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaBebidas());
        }

        private async void Descartaveis(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaDescartaveis());
        }
    }
}