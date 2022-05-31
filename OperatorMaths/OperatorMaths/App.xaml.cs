using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OperatorMaths
{
    public partial class App : Application
    {
        
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                MainPage = new NavigationPage(new interfaceButtonOperator());
                MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.White);
                MainPage.SetValue(NavigationPage.BarTextColorProperty, Color.Black);
                return false; // True = Repeat again, False = Stop the timer
            });
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
