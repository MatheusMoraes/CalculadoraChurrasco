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
        public Menu()
        {
            InitializeComponent();

            Detail = new NavigationPage(new InitialPage()) { BarBackgroundColor = Color.FromRgb(243, 123, 74) };

        }

        private async void Tapped_Inicio(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new InitialPage());
        }

        private async void Tapped_Cortes(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new PaginaCortes());
        }

        private async void Tapped_People(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new People());
        }

        private async void Tapped_PaginaDeCarnes(object sender, EventArgs e)

        {
            await Navigation.PushAsync(new PaginaDeCarnes());
        }






    }
}