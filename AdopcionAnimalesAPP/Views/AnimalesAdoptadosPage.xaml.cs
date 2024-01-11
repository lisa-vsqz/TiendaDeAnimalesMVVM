using AdopcionAnimalesAPP.Models;
using AdopcionAnimalesAPP.Service;
using AdopcionAnimalesAPP.ViewModels;
using CommunityToolkit.Maui.Core;
using System.Collections.ObjectModel;

namespace AdopcionAnimalesAPP;

public partial class AnimalesAdoptadosPage : ContentPage
{
    //private Animal _animal;
    //private string _cedula;
    //private readonly ApiService _ApiService;
    public AnimalesAdoptadosPage()
	{
		InitializeComponent();
        BindingContext = new AnimalesAdoptadosViewModel();
        //ApiService apiService = new ApiService();
        //_ApiService = apiService;
        //_animal = new Animal();
        //_cedula = Preferences.Get("Cedula", "0"); ;
    }

    //protected override async void OnAppearing()
    //{
    //    base.OnAppearing();
    //    List<Animal> listaProp = await _ApiService.BuscarPorPropietario(_cedula);
    //    List<Animal> listaFiltrada = listaProp.Where(animal => animal.Status == 1).ToList();
    //    ObservableCollection<Animal> animalesP = new ObservableCollection<Animal>(listaFiltrada);

    //    if (animalesP.Count != 0) { txtSolicitud.IsVisible = true; }
    //    listastatus.ItemsSource=animalesP;
        


       
    //    List<Animal> listaFiltrada2 = listaProp.Where(animal => animal.Status == 2).ToList();
    //    ObservableCollection<Animal> s = new ObservableCollection<Animal>(listaFiltrada2);
    //    if (s.Count == 0) { txtnoAnimales.IsVisible = true; }
    //    listaadoptados.ItemsSource = s;
        
    //}
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