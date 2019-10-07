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
	public partial class InitialPage : ContentPage
	{
		public InitialPage ()
		{
			InitializeComponent ();
           
		}

     
        private async void Pagina_People(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new People());
        }
    }
}