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
	public partial class PaginaBebidas : ContentPage
	{
		public PaginaBebidas ()
		{
			InitializeComponent ();
		}

        private async void GoPaginaAcompanhamentos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaAcompanhamentos());

        }
    }
}