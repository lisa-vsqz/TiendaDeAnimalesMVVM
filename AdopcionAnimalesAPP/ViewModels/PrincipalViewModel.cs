using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using CommunityToolkit.Maui.Core;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdopcionAnimalesAPP.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class PrincipalViewModel 
    {

        //public Boolean BtnDetalles { get; set; }
        public Boolean BtnVet { get; set; }
        public Boolean BtnAdopt { get; set; }
        public string BtnLogin { get; set; }
        public string Nombre { get; set; }
        public string Cedula;



        public ObservableCollection<Animal> ListaAnimales { get; set; }
        private ApiService apiService;
        public PrincipalViewModel() 
        {
            
            apiService = new ApiService();
            Cedula = Preferences.Get("Cedula", "0");
            botones();
            GetAnimales();

        }



        private async void GetAnimales()
        {
            List<Animal> animalitos = await apiService.Index();
            ListaAnimales = new ObservableCollection<Animal>(animalitos);
        }

        public async void botones()
        {
            if (Cedula != "0")
            {
                Nombre = Preferences.Get("Nombre", "");
                BtnAdopt = true;
                BtnLogin = "Logout";
                BtnVet = true;

            }
            else
            {
                BtnAdopt = false;
                BtnLogin = "Login";
                BtnVet = false;
            }




        }


        private async Task Logueado()
        {
            if (Cedula.Equals("0"))
            {
                await App.Current.MainPage.Navigation.PushAsync(new LoginPage());
            }

        }
        //private async void validarLogin()
        //{
        //    if (Preferences.Get("Cedula", "0").Equals("0"))
        //    { //si no se encuentra en preferencias una cedula, se manda al login.
        //        await Navigation.PushAsync(new LoginPage());
        //    }
        //}



        private async Task MostrarAdoptados()
        {
            await Logueado();
            if (!Cedula.Equals("0"))
            {
                await App.Current.MainPage.Navigation.PushAsync(new AnimalesAdoptadosPage());
            }
        }


        private async Task logs()
        {
            await Logueado();
            if (!Cedula.Equals("0"))
            {
                Preferences.Set("Cedula", "0");
                Preferences.Set("Password", "0");
                await App.Current.MainPage.Navigation.PushAsync(new PrincipalPage());
            }
        }



        //public ICommand OpenDetalles => new Command(async () => await App.Current.MainPage.Navigation.PushAsync(new DetallesAnimalPage( )));
        public ICommand OpenAdoptados => new Command(async () => await MostrarAdoptados());
        public ICommand OpenVeterinarias => new Command(async () => await App.Current.MainPage.Navigation.PushAsync(new VeterinariasPage()));
        public ICommand Login => new Command(async () => await logs());




    }
}
