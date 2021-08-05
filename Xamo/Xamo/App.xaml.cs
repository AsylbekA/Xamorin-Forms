using Xamarin.Forms;
using Xamo.Views;

namespace Xamo
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //MainPage = new Page1();
            //DependencyService.Register<MockDataStore>();
            MainPage = new BasePageTT();
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
