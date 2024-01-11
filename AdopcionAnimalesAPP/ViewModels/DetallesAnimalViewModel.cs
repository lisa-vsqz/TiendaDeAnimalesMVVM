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

    public class DetallesAnimalViewModel
    {
        private Animal _animal;
        private string _cedulaCliente;
        private readonly ApiService _apiService;

        public bool btnSoli { get; set; }
        public string Img { get; set; }
        public string Nombre { get; set; }
        public string NombreCientifico { get; set; }
        public string PaisOrigen { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set; }
        public string Enfermedad { get; set; }
        public ICommand ClickAdoptar => new Command(async () => await OnClickAdoptar());

        public DetallesAnimalViewModel(Animal animal)
        {
            
            _cedulaCliente = Preferences.Get("Cedula", "0");
            _apiService = new ApiService();
            _animal = animal;
            GetAnimal(animal);

        }

        private async void GetAnimal(Animal animal)
        {          
            if (_animal.Status == 1 || _animal.Status == 2)
            {
                btnSoli = false;
            }
            else
            {
                btnSoli = true;
            }
            Img = _animal.Img;
            Nombre = _animal.Nombre;
            NombreCientifico = _animal.NombreCientifico;
            PaisOrigen = _animal.PaisOrigen;
            Altura = _animal.Altura.ToString();
            Peso = _animal.Peso.ToString();
            Enfermedad = _animal.Enfermedad;

        }

        private async Task OnClickAdoptar()
        {
            _animal.Status = 1;
            _animal.Propietario = _cedulaCliente;
            Img = _animal.Img;
            Nombre = _animal.Nombre;
            NombreCientifico = _animal.NombreCientifico;
            PaisOrigen= _animal.PaisOrigen;
            Altura = _animal.Altura.ToString();
            Peso = _animal.Peso.ToString();
            Enfermedad = _animal.Enfermedad;

            await _apiService.UpdateAnimal(_animal.Id, _animal);
            await App.Current.MainPage.Navigation.PopAsync();
        }

        private async Task ClickImg()
        {
            int id = int.Parse(Preferences.Get("identificador", "0"));
            _animal = await _apiService.GetAnimal(id);
        }

        public ICommand Volver => new Command(async () => await App.Current.MainPage.Navigation.PopAsync());
        


    }
}
