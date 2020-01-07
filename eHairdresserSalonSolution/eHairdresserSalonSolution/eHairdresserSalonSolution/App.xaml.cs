using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace eHairdresserSalonSolution
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            Global.APIAddress = "http://ndemirovic.app.fit.ba/";

            
            MainPage = new Navigation.NavigacijskiMeni();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
