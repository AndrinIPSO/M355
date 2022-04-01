using Registrar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Registrar.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        RegisterDaten registerDaten = new RegisterDaten();

        MainPage MP;

        public RegisterViewModel(MainPage mp)
        {
            MP = mp;
            OpenBestaetigung = new Command(OpenB);
        }

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
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
            BestaetigungPage bs = new BestaetigungPage();
            bs.BindingContext = this;
            await MP.Navigation.PushAsync(bs);
        }

        public Command OpenBestaetigung { get; }

    }
}
