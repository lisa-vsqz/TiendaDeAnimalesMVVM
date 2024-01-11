using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
//using Windows.Services.Maps;
//using static Android.Util.EventLogTags;

namespace AdopcionAnimalesAPP.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class RegistroViewModel
    {
        private readonly ApiService apiService;
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Password { get; set; }
      //  private Cliente cliente;

        public RegistroViewModel()
        {
            apiService = new ApiService();
           // cliente = new Cliente();
            Cedula = Cedula;
            Password = Password;
        }

        public ICommand Registrarse =>
            new Command(async () =>
            {
                Cliente cliente = new Cliente
                {
                    Nombre = Nombre,
                    Cedula = Cedula,
                    Direccion = Direccion,
                    Password = Password
                };
                await apiService.PostCliente(cliente); 
                await App.Current.MainPage.Navigation.PopAsync();
            });
        public ICommand Login => new Command(async () => await App.Current.MainPage.Navigation.PopAsync());


    }



}
