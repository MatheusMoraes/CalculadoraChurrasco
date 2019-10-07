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
            
            Detail = new NavigationPage(new Menu()) { BarBackgroundColor = Color.FromRgb(245,123,74)};

            NavigationPage.SetHasNavigationBar(this,false);
        }

    }
}