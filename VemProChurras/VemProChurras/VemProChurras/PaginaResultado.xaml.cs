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
	public partial class PaginaResultado : ContentPage
	{
		public PaginaResultado ()
		{
			InitializeComponent ();
		}

        private async void Inicio(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();


        }

    }
}