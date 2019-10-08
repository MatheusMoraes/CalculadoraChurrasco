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
	public partial class PaginaAcompanhamentos : ContentPage
	{
		public PaginaAcompanhamentos ()
		{
			InitializeComponent ();
		}

        private async void GoPaginaDescartaveis_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaDescartaveis());

        }

    }
}