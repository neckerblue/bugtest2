using bugtest2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace bugtest2.Views
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