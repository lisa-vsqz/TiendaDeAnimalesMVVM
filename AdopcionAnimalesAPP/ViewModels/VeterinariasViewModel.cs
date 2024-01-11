using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AdopcionAnimalesAPP.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class VeterinariasViewModel
    {
        public ObservableCollection<Veterinario> ListaVeterinario { get; set; }
        private ApiService apiService;

        public VeterinariasViewModel() 
        {
            apiService = new ApiService();
            GetVeterinarios();
        }

        private async void GetVeterinarios()
        {
            ListaVeterinario = new ObservableCollection<Veterinario>(await apiService.GetAllVeterinarios());
        }

        public ICommand Atras => new Command(async () => await App.Current.MainPage.Navigation.PopAsync());

    }
}
