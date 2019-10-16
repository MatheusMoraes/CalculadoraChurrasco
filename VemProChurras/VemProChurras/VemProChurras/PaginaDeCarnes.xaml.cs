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
	public partial class PaginaDeCarnes : ContentPage
	{
       

		public PaginaDeCarnes ()
		{
			InitializeComponent ();
            
		}

        private async void Switch_teste(object sender, ToggledEventArgs eventArgs)
        {
            if (SwitchBovina.IsToggled == true)
            {
                var variaveis = new Variaveis
                {
                    CarneBovina = 30
                };

               

                
               
                var paginaResultado = new PaginaResultado();
                paginaResultado.BindingContext = variaveis;
                await Navigation.PushAsync(new PaginaResultado());


            }

        }

        private async void PaginaBebida(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new PaginaResultado());
        }


	}
}