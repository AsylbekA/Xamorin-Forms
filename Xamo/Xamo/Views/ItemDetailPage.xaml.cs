using System.ComponentModel;
using Xamarin.Forms;
using Xamo.ViewModels;

namespace Xamo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}