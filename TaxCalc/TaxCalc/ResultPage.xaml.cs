using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaxCalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
        }

        public ResultPage(TaxCalcClass tc)
        {
            InitializeComponent();
            tc.BerechneBetrag();
            if (tc.isNetto)
            {
                lb_result.Text = $"Betrag: {Convert.ToString(tc.Betrag)} \nNettobetrag: {tc.BetragNetto}" ;

            }
            else
            {
                lb_result.Text = $"Betrag: {Convert.ToString(tc.Betrag)} \nBrutto: {tc.BetragBrutto}";
            }

        }

        private async void bt_back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}