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
        private void hSlider_ValueChanged (object sender, ValueChangedEventArgs e)
        {
            hTxtResult.Text = "Homens:" + Convert.ToInt16(hSlider.Value);
        }
        private void mSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            mTxtResult.Text = "Mulheres:" + Convert.ToInt16(mSlider.Value);
        }
        private void cSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            cTxtResult.Text = "Crianças:" + Convert.ToInt16(cSlider.Value);

        }

        private async void PaginaDeCarnes(object sender, EventArgs e)
        {
            Variaveis variaveis = new Variaveis
            {
                NumHomem = Convert.ToInt16(hSlider.Value),
                NumMulher = Convert.ToInt16(mSlider.Value),
                NumCrianca = Convert.ToInt16(cSlider.Value)
            };
            var paginaCarnes = new PaginaDeCarnes();
            paginaCarnes.BindingContext = variaveis;
            await Navigation.PushAsync(paginaCarnes);
        }
    }
}