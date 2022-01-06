using System;
using Xamarim.Forms.Sample.Services;
using Xamarim.Forms.Sample.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarim.Forms.Sample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            DependencyService.Register<PetDataStore>();
            DependencyService.Register<PetStoreService>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
