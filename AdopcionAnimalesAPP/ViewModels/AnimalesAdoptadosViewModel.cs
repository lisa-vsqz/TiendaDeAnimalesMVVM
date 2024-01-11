using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdopcionAnimalesAPP.ViewModels
{
    [AddINotifyPropertyChangedInterface]

    public class AnimalesAdoptadosViewModel
    {
        //////////////NUEVO

        //public ObservableCollection<Animal> ListaAnimales { get; set; }
        //private ApiService apiService;
        //public string Cedula;
        //public Boolean solicitud;

        //public AnimalesAdoptadosViewModel()
        //{
        //    apiService = new ApiService();
        //    GetAnimalesFiltrados();
        //}



        //protected async Task GetAnimalesFiltrados()
        //{

        //    List<Animal> listaProp = await apiService.BuscarPorPropietario(Cedula);
        //    List<Animal> listaFiltrada = listaProp.Where(animal => animal.Status == 1).ToList();
        //    ObservableCollection<Animal> animalesP = new ObservableCollection<Animal>(listaFiltrada);

        //    if (animalesP.Count != 0) { solicitud = true; }
        //    listastatus.ItemsSource = animalesP;

        //    List<Animal> listaFiltrada2 = listaProp.Where(animal => animal.Status == 2).ToList();
        //    ObservableCollection<Animal> s = new ObservableCollection<Animal>(listaFiltrada2);
        //    if (s.Count == 0) { txtnoAnimales.IsVisible = true; }
        //    listaadoptados.ItemsSource = s;

        //}



        //////////////ANTERIOR

        //private async void OnClickShowDetails(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Click en ver animal", ToastDuration.Short, 14);

        //    await toast.Show();
        //    Animal? animal = e.SelectedItem as Animal;
        //    await Navigation.PushAsync(new DetallesAnimalPage( )
        //    {
        //        BindingContext = animal,
        //    });
        //}

        //private async void ClickImg(object sender, EventArgs e)
        //{
        //    await Navigation.PopAsync();
        //}



    }
}
