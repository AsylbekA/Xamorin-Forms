using Xamarin.Forms;

namespace Xamo
{
    class StartPage:ContentPage
    {
        public StartPage()
        {
            Label header = new Label() { Text = "Привет из Xamarin Forms" };
            this.Content = header;
        }
    }
}
