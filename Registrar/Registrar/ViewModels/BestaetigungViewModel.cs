using Registrar.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Registrar.ViewModels
{
    public class BestaetigungViewModel : ViewModelBase
    {
        public RegisterDaten registerDaten = new RegisterDaten();

        public BestaetigungViewModel()
        {
            
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
}
}
