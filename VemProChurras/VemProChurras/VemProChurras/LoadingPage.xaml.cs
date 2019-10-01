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
	public partial class LoadingPage : ContentPage
	{
		public LoadingPage ()
		{
			InitializeComponent ();
		}


        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaBoi());
        }
    }
}