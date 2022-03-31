using Registrar.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Registrar
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new RegisterVerarbeitung(this);
        }


        // Alte Methode Für Test --> "mit Googgle" Button für neue Methode
        private async void bt_register_Clicked(object sender, EventArgs e)
        {
            bestaetigung bs = new bestaetigung();
            bs.BindingContext = BindingContext;
            await Navigation.PushAsync(bs);
        }
    }
}
