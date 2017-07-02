using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XF_NavigationPage
{
    public class MainPageViewModel
    {
        private INavigation navigation;

        public MainPageViewModel(INavigation nav)
        {
            this.navigation = nav;
            this.ScreenTracitionCommand = new Command(() => ScreenTracition());
        }

        public ICommand ScreenTracitionCommand { get; }
        private void ScreenTracition()
        {
            if(this.navigation != null)
            {
                navigation.PushAsync(new NextPage());
            }
        }
    }
}
