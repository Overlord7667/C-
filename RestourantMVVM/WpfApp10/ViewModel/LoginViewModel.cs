using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp10;

namespace WpfApp10
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void Notify(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        string _login;
        string _pass;
        DataBaseRestaurant _restaurant;
        
        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                Notify("Login");
            }
        }
        public string Pass
        {
            get { return _pass; }
            set
            {
                _pass = value;
                Notify("Pass");
            }
        }
        public LoginViewModel()
        {
            Login = "";
            Pass = "";
            _restaurant = new DataBaseRestaurant();
        }
        public Command RegistrationClick
        {
            get
            {
                return new Command
                    (new Action(() =>
                    {
                        RegistrationView registration = new RegistrationView();
                        registration.ShowDialog();
                    }));
            }
        }
        public Command LoginClick
        {
            get
            {
                return new Command(
                    new Action(()=>
                    {
                    User user = _restaurant.CheckLogin(_login, _pass);
                        if (user != null)
                        {
                            RestMenu restMenu = new RestMenu();
                            restMenu.Show();
                        }
                    })
                    ,
              new Func<bool>(() =>
              {
                  return _login != "" && _pass != "";
              }));
            }
        }
    }
}
