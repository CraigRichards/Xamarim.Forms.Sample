using System.ComponentModel;
using Xamarim.Forms.Sample.ViewModels;
using Xamarin.Forms;

namespace Xamarim.Forms.Sample.Views
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