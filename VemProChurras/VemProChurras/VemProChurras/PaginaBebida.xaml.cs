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
	public partial class PaginaBebida : ContentPage
	{
		public PaginaBebida ()
		{
			InitializeComponent ();
            NavigationPage.SetHasBackButton(this, true);
            
           
		}


        private async void GoPaginaAcompanhamentos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaAcompanhamentos());

        }

    }
}