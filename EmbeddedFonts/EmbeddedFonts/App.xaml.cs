using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

// L'attribut de niveau assembly à ne surtout pas oublier !
[assembly: ExportFont("Samantha Demo.ttf",  Alias = "SamanthaOups")]
namespace EmbeddedFonts
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
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
