using Registrar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Registrar.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {

        public RegisterDaten registerDaten = new RegisterDaten();

        MainPage MP;

        public RegisterViewModel()
        {
            OpenBestaetigung = new Command(OpenB);
        }



        public string Name
        {
            get { return registerDaten.Name; }
            set 
            { 
                registerDaten.Name = value;
                OnPropertyChanged(); 
            }
        }

        public string Mail
        {
            get { return registerDaten.Mail; }
            set
            {
                registerDaten.Mail = value;
                OnPropertyChanged();
            }
        }

        public string ShowPerson
        {
            get
            {
                return $"Name: {this.Name}\nMail: {this.Mail}";
            }
        }

        async void OpenB()
        {
            BestaetigungViewModel bestaetigungViewModel = new BestaetigungViewModel();
            bestaetigungViewModel.registerDaten = this.registerDaten;
            await Application.Current.MainPage.Navigation.PushAsync(new BestaetigungPage(bestaetigungViewModel));

            //BestaetigungPage bs = new BestaetigungPage();
            //bs.BindingContext = this;
            //await MP.Navigation.PushAsync(bs);
        }

        public Command OpenBestaetigung { get; }

    }
}
