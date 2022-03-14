using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TaxCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void bt_calc_Clicked(object sender, EventArgs e)
        {
            try
            {
                int ttt = pk_prozent.SelectedIndex;
                TaxCalcClass tc = new TaxCalcClass()
                { 
                    Betrag = float.Parse(en_amount.Text),
                };

                switch (ttt)
                {
                    case -1:
                        throw new Exception("No Entry");
                    case 0:
                        tc.ustProzent = 8f;
                        break;
                    case 1:
                        tc.ustProzent = 3.5f;
                        break;
                    case 2:
                        tc.ustProzent = 2.5f;
                        break;
                    default:
                        break;
                }

                if (rb_Netto.IsChecked)
                {
                    tc.isNetto = true;
                }
                else
                {
                    tc.isNetto = false;  
                }

                await Navigation.PushAsync(new ResultPage(tc));

            }
            catch (Exception)
            {
                await DisplayAlert("Fehler", "Eine Eingabe ist inkorrekt","OK");
            }
        }
    }
}
