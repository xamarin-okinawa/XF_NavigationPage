using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF_NavigationPage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            this.BindingContext = new MainPageViewModel(Navigation);
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NextPage());
        }
    }
}
