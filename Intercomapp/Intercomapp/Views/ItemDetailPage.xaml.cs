using System.ComponentModel;
using Xamarin.Forms;
using Intercomapp.ViewModels;

namespace Intercomapp.Views
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