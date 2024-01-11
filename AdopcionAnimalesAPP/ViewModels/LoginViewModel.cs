using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdopcionAnimalesAPP.ViewModels
{
    [AddINotifyPropertyChangedInterface]
 
    public class LoginViewModel
    {
        private ApiService apiService;
        private Cliente _cliente;
        public string Cedula { get; set; }
        public string Password { get; set; }

        public LoginViewModel()
        {
            apiService = new ApiService();
            _cliente = new Cliente();
            Cedula= "";
            Password = "";
        }

        public ICommand Boton_Ingresar => new Command(async () => await Ingreso());



        private async Task Ingreso()
        {
            if (!string.IsNullOrWhiteSpace(Cedula) && !string.IsNullOrWhiteSpace(Password))
            {
                _cliente.Cedula = Cedula;
                _cliente.Password = Password;

                Cliente usuario = await apiService.GetCliente(_cliente.Cedula);

                if (usuario != null && usuario.Password == _cliente.Password)
                {

                    Preferences.Set("Cedula", _cliente.Cedula);
                    Preferences.Set("Password", _cliente.Password);
                    Preferences.Set("Nombre", usuario.Nombre);
                    await App.Current.MainPage.Navigation.PopAsync();
                }
            }
        }


        public ICommand Registro =>
            new Command(() =>
            {
                App.Current.MainPage.Navigation.PushAsync(new RegistroPage());
            }
            );



    }
}
