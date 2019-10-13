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
	public partial class People : ContentPage
	{
		public People ()
		{
			InitializeComponent ();


          
		}
        //private void hSlider_ValueChanged (object sender, ValueChangedEventArgs e)
        //{
        //    hTxtResult.Text = "Homens:" + Convert.ToInt16(hSlider.Value);
          
        //}
        //private void mSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    mTxtResult.Text = "Mulheres:" + Convert.ToInt16(mSlider.Value);
        //}
        //private void cSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    cTxtResult.Text = "Crianças:" + Convert.ToInt16(cSlider.Value);
        //}

        private async void PaginaCarnes(object sender, EventArgs e)
        {

            var churrasco = new Churrasco_Controller()
            {
                NumCrianca = Convert.ToInt32(Eteste.Text)
               
            };

            var resultado = new Resultado();
            resultado.BindingContext = churrasco;

            await Navigation.PushAsync(new Resultado());

        }

    }
}