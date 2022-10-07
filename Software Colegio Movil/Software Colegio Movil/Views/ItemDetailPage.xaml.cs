using Software_Colegio_Movil.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Software_Colegio_Movil.Views
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